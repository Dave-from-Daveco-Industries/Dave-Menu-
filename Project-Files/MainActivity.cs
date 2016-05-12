using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace DaveMenu
{
    [Activity(Label = "DaveMenu", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button startButton = FindViewById<Button>(Resource.Id.startButton);
            Button settingsButton = FindViewById<Button>(Resource.Id.settingsButton);

            startButton.Click += startButton_Click;
            settingsButton.Click += SettingsButton_Click;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(SettingsActivity));
            StartActivity(intent);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(SearchMenu));
            StartActivity(intent);
        }
    }
}

