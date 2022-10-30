namespace CardGame;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

	protected override Window CreateWindow(IActivationState activationState)
	{
		var window = base.CreateWindow(activationState);
		window.Activated += Window_Activated;
		return window;
	}

	private async void Window_Activated(object sender, EventArgs e)
	{
/*#if WINDOWS || MACOS
		if (sender is Window window)
		{

			window.Width = 700;
			window.Height = 627;

			// Give it time to resize
			await window.Dispatcher.DispatchAsync(() => { });
		}
#endif*/
	}
}
