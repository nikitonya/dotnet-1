using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promproglab1.Model
{
    interface IFunction
    {
        public abstract double GetValue(double x);

        public abstract double GetDerivative(double x);

    }
}
