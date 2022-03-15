using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promproglab1.Model
{
    internal class Const : IFunction
    {
        private double _a;
        public Const(double a)
        {
            _a = a;
        }

        public Const()
        {
        }

        public double GetValue(double x)
        {
            return _a;
        }

        public double GetDerivative(double x)
        {
            return 0;
        }



    }
}
