using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promproglab1.Model
{
    internal class LinearFunction : IFunction
    {
        private double _k;
        private double _b;

        public LinearFunction(double k, double b)
        {
            _k = k;
            _b = b;
        }

        public double GetValue(double x)
        {
            return _k * x + _b;
        }

        public double GetDerivative(double x)
        {
            return _k;
        }
    }
}
