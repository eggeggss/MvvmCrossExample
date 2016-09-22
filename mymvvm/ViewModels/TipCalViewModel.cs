using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Views;
using mymvvm.Interface;
using mymvvm.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace mymvvm.ViewModels
{
   
    public class TipCalViewModel : MvxViewModel
    {

        private string _hello = "Hello MvvmCross";
        public string Hello
        {
            get { return _hello; }
            set { _hello = value; RaisePropertyChanged(() => Hello); }
        }
        
        private readonly ICalculationService _calculationService;
        
        public TipCalViewModel(ICalculationService calculationService)
        {
           
            this._calculationService = calculationService;
            _generosity = 20;
            _subTotal = 100;
            ReCalc();
        }
        
       
        private double _subTotal;


        public double SubTotal
        {
            get { return _subTotal; }
            set { _subTotal = value;
                RaisePropertyChanged(() => SubTotal);
               
                ReCalc();
            }
        }

        private double _generosity;

        public double Generosity
        {
            get { return _generosity; }
            set {
                _generosity = value;

                RaisePropertyChanged(() => Generosity);
               
                ReCalc();
            }
        }

        private double _tip;
        
        public double Tip
        {
            get { return _tip; }
            set {

                this._tip = value;
                RaisePropertyChanged(() => Tip);

            }

        }

        private double _total;

        public double Total
        {
            get { return _total; }
            set { _total = value;

                RaisePropertyChanged(() => Total);
            }
        }


        private void ReCalc()
        {
            this.Tip = _calculationService.Tip(SubTotal, Generosity);
            Total = SubTotal + Tip;
        }

        public IMvxViewModel LoadViewModel(MvxViewModelRequest request, IMvxBundle savedState)
        {
            
            return this;
            // throw new NotImplementedException();
        }
    }
}
