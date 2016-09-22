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
using Cirrious.CrossCore.IoC;
using Cirrious.CrossCore;
using mymvvm.ViewModels;
using mymvvm.Interface;
using TipCal.Droid.Implement;

namespace TipCal.Droid
{
    [Application]
    public class DroidApp:Application
    {

        public static TipCalViewModel ViewModel { set; get; }
        public DroidApp(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {

            MvxSimpleIoCContainer.Initialize();
            
            try
            {
                Mvx.RegisterType<ICalculationService, Command>();
                DroidApp.ViewModel = Mvx.IocConstruct<TipCalViewModel>();
               
            }
            catch (Exception ex)
            {
                Toast.MakeText(this.ApplicationContext, ex.Message, ToastLength.Short).Show();
            }
                //MvxSimpleIoCContainer.Initialize();
            //var iv= Mvx.IocConstruct<TipCalViewModel>();
            ///Setup step = new Setup(this.ApplicationContext);
            //step.Initialize();

            //System.Diagnostics.Debug.WriteLine("", "degub");
        }

    }
}