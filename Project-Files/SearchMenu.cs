using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DaveMenu
{
    [Activity(Label = "SearchMenu")]
    public class SearchMenu : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SearchLayout);


            Button searchButton = FindViewById<Button>(Resource.Id.searchButton);

            searchButton.Click += searchButton_Click;

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(FilteredSearchActivity));
            StartActivity(intent);
        }
    }
}