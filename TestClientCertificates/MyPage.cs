using System;

using Xamarin.Forms;
using ModernHttpClient;
using System.Net.Http;
using System.Text;

namespace TestClientCertificates
{
	public class MyPage : ContentPage
	{
		async void Button_Clicked(object sender, EventArgs e)
		{

			try
			{
				using (var httpClient = new HttpClient(new System.Net.Http.HttpClientHandler()))
				{
					var activationUrl = "http://apiauthadstefanini.softwareestrategico.com/token";

					var postData = "grant_type=password&username=diego.ochoa&password=Software1&scope=all";
					var content = new StringContent(postData, Encoding.UTF8, "application/x-www-form-urlencoded");

					var response = await httpClient.PostAsync(activationUrl, content);
					if (!response.IsSuccessStatusCode)
					{
						System.Diagnostics.Debug.WriteLine(response.StatusCode);
					}
					var result = await response.Content.ReadAsStringAsync();

					//return result;
				}

			}
		    catch(Exception ex)
		    {
		        //return null;
		    }
		}

	public MyPage()
	{
		var button = new Button()
		{
			Text = "Click me"
		};

		button.Clicked += Button_Clicked; ;

		Content = new StackLayout
		{
			Children = {
					new Label { Text = "Hello ContentPage" },
					button
				}
		};
	}



}
}

