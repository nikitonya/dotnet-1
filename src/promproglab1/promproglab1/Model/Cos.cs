using System;

namespace promproglab1.Model
{
    internal class Cos : IFunction
    {
        private double _a;
        public double A
        {
            get { return _a; }
            set { _a = value; }
        }

        public Cos(double a)
        {
            _a = a;
        }

        public IFunction GetDerivative()
        {
            return new Sin(-1);
        }

        public double GetValue(double x)
        {
            return Math.Cos(x);
        }
    }
}
