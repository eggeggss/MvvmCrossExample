using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mymvvm.Interface
{
    public interface ICalculationService
    {
        double Tip(double subTotal, double generosity);
    }
}
