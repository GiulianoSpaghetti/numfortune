namespace numfortune;

public partial class InfoPage : ContentPage
{
	public InfoPage()
	{
		InitializeComponent();
	}
    private async void OnInfo_Click(object sender, EventArgs e)
	{
		await Launcher.Default.OpenAsync(new Uri("https://github.com/GiulianoSpaghetti/numfortune"));
    }

}