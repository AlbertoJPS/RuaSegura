using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Android.Content.PM;
using Plugin.CurrentActivity;
using Android.Support.V7.App;
using System.Threading;

namespace RuaSegura.Droid
{
    [Activity(Label = "Rua Segura", Icon = "@mipmap/ic_launcher", Theme = "@style/MainTheme.Splash", MainLauncher = true, NoHistory = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize, ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    //ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    //ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Thread.Sleep(2000);
            //Finish();
            //// Disable activity slide-in animation
            //OverridePendingTransition(0, 0);
        }

        protected override void OnResume()
        {
            base.OnResume();
            StartActivity(typeof(MainActivity));
            

        }
    }
}