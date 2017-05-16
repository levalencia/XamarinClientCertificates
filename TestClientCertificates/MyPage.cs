using System;

using Xamarin.Forms;

namespace TestClientCertificates
{
	public class MyPage : ContentPage
	{
		void Button_Clicked(object sender, EventArgs e)
		{

		}

		public MyPage()
		{
			var button = new Button()
			{
				Text = "Click me"
			};

			button.Clicked += Button_Clicked;;

			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

