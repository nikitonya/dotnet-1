using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promproglab1.Model
{
    internal class Cosinus : IFunction
    {
        private double _x;

        public Cosinus()
        {
           
        }

        public double GetDerivative(double x)
        {
            return -Math.Sin(_x);   
        }

        public double GetValue(double x)
        {
            return Math.Cos(_x);
        }
    }
}
