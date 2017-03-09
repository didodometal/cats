
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Xamarin.Clientes;
using Xamarin.Forms;

namespace App.Xamarin.Cats.Android
{
    [Activity(Label = "Cats", Icon = "@drawable/logo", Theme = "@style/CustomTheme", MainLauncher = true, NoHistory = true)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
            base.OnCreate (bundle);
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;
            Forms.Init (this, bundle);
            LoadApplication (new App());
		}
	}
}

