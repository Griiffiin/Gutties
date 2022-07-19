using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gutties.Droid
{
    [Activity(Label = "SplashActivity", MainLauncher = true, Theme = "@style/MyTheme.splash", NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
        protected override async void OnResume()
        {
            base.OnResume();
            await SimulateStartup();
        }

         async Task SimulateStartup()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}