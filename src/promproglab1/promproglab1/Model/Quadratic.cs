using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promproglab1.Model
{
    internal class Quadratic : IFunction
    {
        private double _a;
        private double _b;
        private double _c;

        public Quadratic(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double GetDerivative(double x)
        {
            return 2 * _a * x + _b; 
        }

        public double GetValue(double x)
        {
            return _a * Math.Pow(x, 2) + _b * x + _c;
        }
    }
}
