using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using L09_ViewModel;
using STC.Xamarin.MVVMFramework;

namespace L09_Android
{
    [Activity(Label = "L09_Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        int count = 1;
        protected override void OnCreate(Bundle bundle)
        {

            //:lab:改寫成Binding至ViewModel
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            button.Click += (sender, e) =>
            {
                button.Text = string.Format("{0} clicks!", count++);
            };
        }
    }
}

