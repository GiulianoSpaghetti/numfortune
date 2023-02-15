using System.Collections.ObjectModel;

namespace numfortune;

public partial class MainPage : ContentPage
{
	HttpClient client;
	public MainPage()
	{
		InitializeComponent();
		client=new HttpClient();
        tick();
    }

	private async void tick()
	{
        var httpResponse = await client.GetAsync("https://api.justyy.workers.dev/api/fortune");

        if (httpResponse.IsSuccessStatusCode)
        {
            String s = await httpResponse.Content.ReadAsStringAsync();
            s = s.Substring(1, s.Length - 2);
            s = s.Replace("\\n", "<br />");
            s = s.Replace("\\t", "	");
            s = s.Replace("\\\"", "\"");
            lblFortune.Text = s;
        }

    }

    private async void OnRefresh_Click(object sender, EventArgs e)
	{
        tick();
    }
}

