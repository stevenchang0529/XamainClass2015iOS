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


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            MainViewModel model = new MainViewModel();
            button.Click += CommandGenerate.BindingCommand(model.DoButtonClick);
            model.AddBinding(c => c.ButtonText, () => button.Text, c => button.Text=c);
        }
    }
}

