
namespace CardGame.Views {
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void OnNewGameClicked(object sender, EventArgs e)
		{
			SemanticScreenReader.Announce(btnNewGame.Text);

			await Shell.Current.GoToAsync("game");
		}

		private async void OnSettingsClicked(object sender, EventArgs e)
		{
			SemanticScreenReader.Announce(btnSettings.Text);

			await Shell.Current.GoToAsync("settings");
		}
	}
}

