using System.Collections.Generic;
using CardGame.Framework;

namespace BlackJack
{
	public class BlackJackGame
	{
		#region Fields

        // private Deck and Player objects for the current deck, dealer, and player
		private Deck deck;
		private Player dealer;
        private Player player;

		#endregion

		#region Properties

        // public properties to return the current player, dealer, and current deck
        public Player CurrentPlayer { get { return player; } }
		public Player Dealer { get { return dealer; } }
        public Deck CurrentDeck { get { return deck; } }

		#endregion

		#region Main Game Constructor

        /// <summary>
        /// Main Constructor for BlackJack Game
        /// </summary>
        /// <param name="initBalance"></param>
		public BlackJackGame(int initBalance, string playerImage, string playerName)
		{
			// Create a dealer and one player with the initial balance.
			dealer = new Player();
            player = new Player(initBalance, playerImage, playerName);
		}

		#endregion

		#region Game Methods

        /// <summary>
        /// Deals a new game.  This is invoked through the Deal button in BlackJackForm.cs
        /// </summary>
		public void DealNewGame()
		{
            // Create a new deck and then shuffle the deck
            deck = new Deck();
            deck.Shuffle();

			// Reset the player and the dealer's hands in case this is not the first game
            player.NewHand();
            dealer.NewHand();

			// Deal two cards to each person's hand
			for (int i = 0; i < 2; i++)
			{
				Card c = deck.Draw();
				player.Hand.Cards.Add(c); 

				Card d = deck.Draw();
				// Set the dealer's second card to be facing down
				if (i == 1)
					d.IsCardUp = false;

				dealer.Hand.Cards.Add(d);
			}

            // Give the player and the dealer a handle to the current deck
            player.CurrentDeck = deck;
            dealer.CurrentDeck = deck;
		}

        /// <summary>
        /// This method finishes playing the dealer's hand
        /// </summary>
        public void DealerPlay()
        {
            // Dealer's card that was facing down is turned up when they start playing
            dealer.Hand.Cards[1].IsCardUp = true;

            // Check to see if dealer has a hand that is less than 17
            // If so, dealer should keep hitting until their hand is greater or equal to 17
            if (dealer.Hand.GetSumOfHand() < 17)
            {
                dealer.Hit();
                DealerPlay();
            }
        }

        /// <summary>
        /// Update the player's record with a loss
        /// </summary>
        public void PlayerLose()
        {
            player.Losses += 1;
        }

        /// <summary>
        /// Update the player's record with a win
        /// </summary>
        public void PlayerWin()
        {
            player.Balance += player.Bet * 2;
            player.Wins += 1;
        }
		#endregion
	}
}
