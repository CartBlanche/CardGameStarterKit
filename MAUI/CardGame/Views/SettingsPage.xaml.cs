namespace CardGame.Views;

public partial class SettingsPage : ContentPage
{
	public IEnumerable<string> PlayerImages => new List<string>() { 
		"cat.jpg",
		"dog.jpg",
		"rubberduck.jpg",
		"soccerball.jpg",
	};

	static string playerName = "Karen";
	public static string PlayerName { get { return playerName; } set { playerName = value; } }

	static string playerImage = "cat.jpg";
	public static string PlayerImage { get { return playerImage; } set { playerImage = value; } }
	public SettingsPage()
	{
		InitializeComponent();

		BindingContext = this;
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();

		previewImage.Source = playerImage;
		edtPlayerName.Text = playerName;
	}

	private void playerImageListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
		if (e.SelectedItem == null)
			return;

		previewImage.Source = (string)e.SelectedItem;
	}

	private async void btnOK_Clicked(object sender, EventArgs e)
	{
		if(previewImage.Source is FileImageSource fileImageSource)
			PlayerImage = fileImageSource.File;
		PlayerName = edtPlayerName.Text;

		await Shell.Current.Navigation.PopAsync();
	}

	private async void btnCancel_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.Navigation.PopAsync();
	}
}