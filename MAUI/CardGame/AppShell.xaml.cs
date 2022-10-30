using CardGame.Views;

namespace CardGame
{

	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();

			RegisterRoutes();
		}

		private void RegisterRoutes()
		{
			Routing.RegisterRoute("main", typeof(MainPage));
			Routing.RegisterRoute("game", typeof(GamePage));
			Routing.RegisterRoute("settings", typeof(SettingsPage));
		}
	}
}
