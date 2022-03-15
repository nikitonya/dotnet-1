using System;

namespace promproglab1.Model
{
    internal class Sin : IFunction
    {
        private double _a;

        public Sin(double a)
        {
            _a = a;
        }

        public IFunction GetDerivative()
        {
            return new Cos(1);
        }

        public double GetValue(double x)
        {
            return Math.Sin(x);
        }
    }
}
