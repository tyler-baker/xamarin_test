using Android.App;
using Android.Widget;
using Android.OS;
using RestSharp;

namespace HelloWorld
{
	[Activity(Label = "HelloWorld", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		//int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.myButton);

			string url = "http://www.thomas-bayer.com/sqlrest/CUSTOMER/";

			var client = new RestClient(url);


			var request = new RestRequest();
			client.ExecuteAsync(request, response =>
			{
				button.Click += delegate { button.Text = url; };
				//Toast.MakeText(BaseContext, url, ToastLength.Long);
				//button.Text = response.Content;
			});

			//button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

		}
	}
}

