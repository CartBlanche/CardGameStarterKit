using System;

namespace CardGame.ViewModels
{
	internal class GameViewModel : BaseViewModel
	{
		public GameViewModel()
		{
			Title = "BlackJack Casino";
		}

		int myAccount;
		public int MyAccount {
			get { return myAccount; }
			set { SetProperty(ref myAccount, value); }
		}

		int myBets;
		public int MyBet {
			get { return myBets; }
			set { SetProperty(ref myBets, value); }
		}

		int wins;
		public int Wins {
			get { return wins; }
			set { SetProperty(ref wins, value); }
		}

		int losses;
		public int Losses {
			get { return losses; }
			set { SetProperty(ref losses, value); }
		}

		int ties;
		public int Ties {
			get { return ties; }
			set { SetProperty(ref ties, value); }
		}

		int playerTotal;
		public int PlayerTotal
		{
			get { return playerTotal; }
			set { SetProperty(ref playerTotal, value); }
		}
	}
}
