using BlackJack;
using CardGame.Framework;
using Microsoft.Maui;

namespace CardGame.Views;

public partial class GamePage : ContentPage
{
	private BlackJackGame game = new BlackJackGame(SettingsPage.PlayerInitialBalance, 
		SettingsPage.PlayerImage, 
		SettingsPage.PlayerName);

	private Image[] playerCards;
	private Image[] dealerCards;
	private bool firstTurn;


	public int MyAccount { get; set; }
	public int MyBet { get; set; }
	public int Wins { get; set; }
	public int Losses { get; set; }
	public int Ties { get; set; }
	public GamePage()
	{
		InitializeComponent();

		LoadCardSkinImages();

		SetUpNewGame();

		BindingContext = this;
	}

	private void SetUpNewGame()
	{
		btnDeal.IsEnabled = true;
		btnDoubleDown.IsEnabled = false;
		btnStand.IsEnabled = false;
		btnHit.IsEnabled = false;
		btnClear.IsEnabled = true;

		btn10.IsEnabled = true;
		btn25.IsEnabled = true;
		btn50.IsEnabled = true;
		btn100.IsEnabled = true;

		imgPlayerPicture.Source = game.CurrentPlayer.Image;
		lblPlayerName.Text = game.CurrentPlayer.Name;
		lblGameOver.IsVisible = false;
		lblPlayerTotal.IsVisible = false;

		firstTurn = true;

		ShowBankValue();
	}

	private void ShowBankValue()
	{
		MyAccount = (int)game.CurrentPlayer.Balance;
		MyBet = (int)game.CurrentPlayer.Bet;
	}

	private void LoadCardSkinImages()
	{
		try
		{
			playerCards = new Image[] { playerCard1, playerCard2, playerCard3, playerCard4, playerCard5, playerCard6 };
			dealerCards = new Image[] { dealerCard1, dealerCard2, dealerCard3, dealerCard4, dealerCard5, dealerCard6 };

			// loop through and make them invisable for now
			foreach (var card in playerCards)
			{
				card.IsVisible = false;
			}

			foreach (var card in dealerCards)
			{
				card.IsVisible = false;
			}
		}
		catch (OutOfMemoryException)
		{
			DisplayAlertAndExit("Card skin images are not loading correctly.  Make sure the card skin images are in the correct location.");
		}
	}

	private void btnHit_Clicked(object sender, EventArgs e)
	{
		// It is no longer the first turn, set this to false so that the cards will all be facing upwards
		firstTurn = false;

		// Hit once and update UI cards
		game.CurrentPlayer.Hit();
		UpdateUIPlayerCards();

		// Check to see if player has bust
		if (game.CurrentPlayer.HasBust())
		{
			EndGame(EndResult.PlayerBust);
		}
	}

	private void btnStand_Clicked(object sender, EventArgs e)
	{
		// Dealer should finish playing and the UI should be updated
		game.DealerPlay();
		UpdateUIPlayerCards();

		// Check who won the game
		EndGame(GetGameResult());
	}

	private EndResult GetGameResult()
	{
		EndResult endState;
		// Check for blackjack
		if (game.Dealer.Hand.NumCards == 2 && game.Dealer.HasBlackJack())
		{
			endState = EndResult.DealerBlackJack;
		}
		// Check if the dealer has bust
		else if (game.Dealer.HasBust())
		{
			endState = EndResult.DealerBust;
		}
		else if (game.Dealer.Hand.CompareFaceValue(game.CurrentPlayer.Hand) > 0)
		{
			//dealer wins
			endState = EndResult.DealerWin;
		}
		else if (game.Dealer.Hand.CompareFaceValue(game.CurrentPlayer.Hand) == 0)
		{
			// push
			endState = EndResult.Push;
		}
		else
		{
			// player wins
			endState = EndResult.PlayerWin;
		}
		return endState;
	}

	private async void btnDeal_Clicked(object sender, EventArgs e)
	{
		try
		{
			// If the current bet is equal to 0, ask the player to place a bet
			if ((game.CurrentPlayer.Bet == 0) && (game.CurrentPlayer.Balance > 0))
			{
				await DisplayAlert("FYI", "You must place a bet before the dealer deals.", "OK");
			}
			else
			{
				// Place the bet
				game.CurrentPlayer.PlaceBet();
				ShowBankValue();

				// Clear the table, set up the UI for playing a game, and deal a new game
				ClearTable();
				SetUpGameInPlay();
				game.DealNewGame();
				UpdateUIPlayerCards();

				// Check see if the current player has blackjack
				if (game.CurrentPlayer.HasBlackJack())
				{
					EndGame(EndResult.PlayerBlackJack);
				}
			}
		}
		catch (Exception NotEnoughMoneyException)
		{
			DisplayAlertAndExit(NotEnoughMoneyException.Message);
		}
	}

	private async void EndGame(EndResult endState)
	{
		switch (endState)
		{
			case EndResult.DealerBust:
				lblGameOver.Text = "Dealer Bust!";
				game.PlayerWin();
				break;
			case EndResult.DealerBlackJack:
				lblGameOver.Text = "Dealer BlackJack!";
				game.PlayerLose();
				break;
			case EndResult.DealerWin:
				lblGameOver.Text = "Dealer Won!";
				game.PlayerLose();
				break;
			case EndResult.PlayerBlackJack:
				lblGameOver.Text = "BlackJack!";
				game.CurrentPlayer.Balance += (game.CurrentPlayer.Bet * (decimal)2.5);
				game.CurrentPlayer.Wins += 1;
				break;
			case EndResult.PlayerBust:
				lblGameOver.Text = "You Bust!";
				game.PlayerLose();
				break;
			case EndResult.PlayerWin:
				lblGameOver.Text = "You Won!";
				game.PlayerWin();
				break;
			case EndResult.Push:
				lblGameOver.Text = "Push";
				game.CurrentPlayer.Push += 1;
				game.CurrentPlayer.Balance += game.CurrentPlayer.Bet;
				break;
		}

		// Update the "My Record" values
		Wins = game.CurrentPlayer.Wins;
		Losses = game.CurrentPlayer.Losses;
		Ties = game.CurrentPlayer.Push;
		SetUpNewGame();
		ShowBankValue();
		lblGameOver.IsVisible = true;

		// Check if the current player is out of money
		if (game.CurrentPlayer.Balance == 0)
		{
			await DisplayAlert("Out of Money!", "Please create a new game to play again.", "OK");
			await Shell.Current.Navigation.PopAsync();
		}
	}

	private void UpdateUIPlayerCards()
	{
		// Update the value of the hand
		lblPlayerTotal.Text = game.CurrentPlayer.Hand.GetSumOfHand().ToString();

		List<Card> pcards = game.CurrentPlayer.Hand.Cards;
		for (int i = 0; i < pcards.Count; i++)
		{
			// Load each card from file
			LoadCard(playerCards[i], pcards[i]);
			playerCards[i].IsVisible = true;
			// TODO playerCards[i].BringToFront();
		}

		List<Card> dcards = game.Dealer.Hand.Cards;
		for (int i = 0; i < dcards.Count; i++)
		{
			LoadCard(dealerCards[i], dcards[i]);
			dealerCards[i].IsVisible = true;
			// TODO dealerCards[i].BringToFront();
		}
	}

	private void LoadCard(Image image, Card card)
	{
		try
		{
			string imageSource = string.Empty;

			switch (card.Suit)
			{
				case Suit.Diamonds:
					imageSource += "di";
					break;
				case Suit.Hearts:
					imageSource += "he";
					break;
				case Suit.Spades:
					imageSource += "sp";
					break;
				case Suit.Clubs:
					imageSource += "cl";
					break;
			}

			switch (card.FaceVal)
			{
				case FaceValue.Ace:
					imageSource += "1";
					break;
				case FaceValue.King:
					imageSource += "k";
					break;
				case FaceValue.Queen:
					imageSource += "q";
					break;
				case FaceValue.Jack:
					imageSource += "j";
					break;
				case FaceValue.Ten:
					imageSource += "10";
					break;
				case FaceValue.Nine:
					imageSource += "9";
					break;
				case FaceValue.Eight:
					imageSource += "8";
					break;
				case FaceValue.Seven:
					imageSource += "7";
					break;
				case FaceValue.Six:
					imageSource += "6";
					break;
				case FaceValue.Five:
					imageSource += "5";
					break;
				case FaceValue.Four:
					imageSource += "4";
					break;
				case FaceValue.Three:
					imageSource += "3";
					break;
				case FaceValue.Two:
					imageSource += "2";
					break;
			}

			imageSource += ".gif";
			
			//check to see if the card should be faced down or up;
			if (!card.IsCardUp)
				imageSource = "cardskin.png";

			image.Source = imageSource;
		}
		catch (ArgumentOutOfRangeException)
		{
			DisplayAlertAndExit("Card images are not loading correctly.  Make sure all card images are in the right location.");
		}
	}

	private void SetUpGameInPlay()
	{
		btn10.IsEnabled = false;
		btn25.IsEnabled = false;
		btn50.IsEnabled = false;
		btn100.IsEnabled = false;
		btnClear.IsEnabled = false;
		btnStand.IsEnabled = true;
		btnHit.IsEnabled = true;
		btnDeal.IsEnabled = false;

		if (firstTurn)
			btnDoubleDown.IsEnabled = true;

		lblGameOver.IsVisible = false;
		lblPlayerTotal.IsVisible = true;
	}

	private void ClearTable()
	{
		for (int i = 0; i < 6; i++)
		{
			dealerCards[i].Source = null;
			dealerCards[i].IsVisible = false;

			playerCards[i].Source = null;
			playerCards[i].IsVisible = false;
		}
	}

	private async void DisplayAlertAndExit(string message)
	{
		await DisplayAlert("Error", message, "OK");
		await Shell.Current.Navigation.PopAsync();
	}

	private void btnClear_Clicked(object sender, EventArgs e)
	{
		//Clear the bet amount
		game.CurrentPlayer.ClearBet();
		ShowBankValue();
	}

	private void btn10_Clicked(object sender, EventArgs e)
	{
		Bet(10);
	}

	private void Bet(int betValue)
	{
		try
		{
			// Update the bet amount
			game.CurrentPlayer.IncreaseBet(betValue);

			// Update the "My Bet" and "My Account" values
			ShowBankValue();
		}
		catch (Exception NotEnoughMoneyException)
		{
			DisplayAlertAndExit(NotEnoughMoneyException.Message);
		}
	}

	private void btn25_Clicked(object sender, EventArgs e)
	{
		Bet(25);
	}

	private void btn50_Clicked(object sender, EventArgs e)
	{
		Bet(50);
	}

	private void btn100_Clicked(object sender, EventArgs e)
	{
		Bet(100);
	}

	private void btnDoubleDown_Clicked(object sender, EventArgs e)
	{
		try
		{
			// Double the player's bet amount
			game.CurrentPlayer.DoubleDown();
			UpdateUIPlayerCards();
			ShowBankValue();

			//Make sure that the player didn't bust
			if (game.CurrentPlayer.HasBust())
			{
				EndGame(EndResult.PlayerBust);
			}
			else
			{
				// Otherwise, let the dealer finish playing
				game.DealerPlay();
				UpdateUIPlayerCards();
				EndGame(GetGameResult());
			}
		}
		catch (Exception NotEnoughMoneyException)
		{
			DisplayAlertAndExit(NotEnoughMoneyException.Message);
		}
	}
}