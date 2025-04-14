namespace numfortune;

public partial class InfoPage : ContentPage
{
	public static readonly Uri uri = new Uri("https://github.com/GiulianoSpaghetti/numfortune");

    public InfoPage()
	{
		InitializeComponent();
	}
    private async void OnInfo_Click(object sender, EventArgs e)
	{
		await Launcher.Default.OpenAsync(uri);
    }

}