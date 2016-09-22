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
using mymvvm.Interface;


namespace TipCal.Droid.Implement
{
    public class Command: ICalculationService
    {
        public double Tip(double subTotal, double generosity)
        {
            return subTotal * generosity / 100.0;
            // throw new NotImplementedException();
        }
    }

    
}