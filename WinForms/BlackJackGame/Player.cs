using System.Collections.Generic;
using BlackJack.CardGameFramework;
using System.Windows.Forms;
using System;

namespace BlackJack
{
    public class Player
    {
        // Objects to store player information
        private decimal balance;
        private BlackJackHand hand;
        private decimal bet;
        private int wins;
        private int losses;
        private int pushes;
        private string image;
        private string name;
        private Deck currentDeck;
        // Creates a list of cards
        private List<Card> cards = new List<Card>();

        public Deck CurrentDeck { get { return currentDeck; } set { currentDeck = value; } }
        public string Image { get { return image; } set { image = value; } }
        public BlackJackHand Hand { get { return hand; } }
        public string Name { get { return name; } set { name = value; } }
        public decimal Bet { get { return bet; } set { bet = value; } }
        public decimal Balance { get { return balance; } set { balance = value; } }
        public int Wins { get { return wins; } set { wins = value; } }
        public int Losses { get { return losses; } set { losses = value; } }
        public int Push { get { return pushes; } set { pushes = value; } }

        /// <summary>
        /// Creates a player with a default balance account (i.e. it doesn't matter what the dealer's balance is)
        /// </summary>
        public Player() : this(-1) { }

        /// <summary>
        ///  Creates a player with a new hand and new balance
        /// </summary>
        /// <param name="newBalance"></param>
        public Player(int newBalance)
        {
            // Sets the player's image and name that is displayed in the picture frame in the UI.
            this.image = Properties.Settings.Default.PlayerImage;
            this.name = Properties.Settings.Default.PlayerName;
            this.hand = new BlackJackHand();
            this.balance = newBalance;
        }

        /// <summary>
        /// Increases the bet amount each time a bet is added to the hand.  Invoked through the betting coins in the BlackJackForm.cs UI
        /// </summary>
        /// <param name="amt"></param>
        public void IncreaseBet(decimal amt)
        {
            // Check to see if the user has enough money to make this bet
            if ((balance - (bet + amt)) >= 0)
            {
                // Add money to the bet
                bet += amt;
            }
            else
            {
                throw new Exception("You do not have enough money to make this bet.");
            }
        }

        /// <summary>
        /// Places the bet and subtracts the amount from "My Account"
        /// </summary>
        public void PlaceBet()
        {
            // Check to see if the user has enough money to place this bet
            if ((balance - bet) >= 0)
            {
                balance = balance - bet;
            }
            else
            {
                throw new Exception("You do not have enough money to place this bet.");
            }
        }

        /// <summary>
        /// Creates a new hand for the current player
        /// </summary>
        /// <returns>BlackJackHand</returns>
        public BlackJackHand NewHand()
        {
            this.hand = new BlackJackHand();
            return this.hand;
        }

        /// <summary>
        /// Set the bet value back to 0
        /// </summary>
        public void ClearBet()
        {
            bet = 0;
        }

        /// <summary>
        /// Check if the current player has BlackJack
        /// </summary>
        /// <returns>Returns true if the current player has BlackJack</returns>
        public bool HasBlackJack()
        {
            if (hand.GetSumOfHand() == 21)
                return true;
            else return false;
        }

        /// <summary>
        /// Check if the current player has bust
        /// </summary>
        /// <returns>returns true if the current player has bust</returns>
        public bool HasBust()
        {
            if (hand.GetSumOfHand() > 21)
                return true;
            else return false;
        }

        /// <summary>
        /// Player has hit, draw a card from the deck and add it to the player's hand
        /// </summary>
        public void Hit()
        {
            Card c = currentDeck.Draw();
            hand.Cards.Add(c);
        }

        /// <summary>
        /// Player has chosen to double down, double the player's bet and hit once
        /// </summary>
        public void DoubleDown()
        {
            IncreaseBet(Bet);
            // Only decrease the balance by half of the current bet
            balance = balance - (bet / 2);
            Hit();
        }
    }
}
