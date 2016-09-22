using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.CrossCore;
using mymvvm.ViewModels;


namespace TipCal.Droid
{
    [Activity(Label = "TipCal.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class TipCalView : MvxActivity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //var viewmodel=Mvx.IocConstruct<TipCalViewModel>();
           // Mvx.Resolve<ICalculationService>();
          //  viewmodel.SubTotal = 999;
            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button>(Resource.Id.MyButton);

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

