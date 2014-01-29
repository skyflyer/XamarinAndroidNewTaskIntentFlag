using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace SimpleAndroid
{
	[Activity (Label = "First one", MainLauncher = true)]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				var intent = new Intent (this, typeof(SecondActivity));
				intent.SetFlags(ActivityFlags.NewTask);
				StartActivity (intent);
			};
		}
	}

	[Activity (Label = "Second one")]
	public class SecondActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Second);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

			button.Click += delegate {
				var intent = new Intent (this, typeof(MainActivity));
				intent.SetFlags(ActivityFlags.NewTask);
				StartActivity (intent);
			};
		}
	}
}


