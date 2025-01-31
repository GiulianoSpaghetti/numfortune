using System.Collections.ObjectModel;

namespace numfortune;

public partial class MainPage : ContentPage
{
	HttpClient client= new HttpClient();
    HttpResponseMessage httpResponse;
    public MainPage()
    {
		InitializeComponent();
        	tick();
    }

    private async void tick()
    {
        try
        {
            httpResponse = await client.GetAsync("https://helloacm.com/api/fortune/");
            if (httpResponse.IsSuccessStatusCode)
            {
                String s = await httpResponse.Content.ReadAsStringAsync();
                s = s.Substring(1, s.Length - 2);
                s = s.Replace("\\n", System.Environment.NewLine);
                s = s.Replace("\\t", "	");
                s = s.Replace("\\\"", "\"");
                lblFortune.Text = s;
            }
            else
            {
                lblFortune.Text = $"The HTTP status code is ${httpResponse.StatusCode}";
            }
        }
        catch (InvalidOperationException ex)
        {
            lblFortune.Text = ex.Message;
        }
        catch (AggregateException ex)
        {
            lblFortune.Text = ex.Message;
        }



    }

    private void OnRefresh_Click(object sender, EventArgs e)
	{
        tick();
    }
}

