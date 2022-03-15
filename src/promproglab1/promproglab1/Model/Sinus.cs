using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promproglab1.Model
{
    internal class Sinus : IFunction
    {
        private double _x;

        public Sinus()
        {
        }

        public  double GetDerivative(double x)
        {
            return Math.Cos(x);
        }

        public double GetValue(double x)
        {
            return Math.Sin(x);
        }
    }
}
