using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace TipCal.Droid.Views
{
    [Activity(Label = "View for FirstViewModel",MainLauncher =false)]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
        }
    }
}