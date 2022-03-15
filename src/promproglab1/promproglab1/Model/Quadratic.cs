using System;

namespace promproglab1.Model
{
    internal class Quadratic : IFunction
    {
        private double _a;
        public double A
        {
            get { return _a; }
            set { _a = value; }
        }

        private double _b;
        public double B
        {
            get { return _b; }
            set { _b = value; }
        }

        private double _c;
        public double C
        {
            get { return _c; }
            set { _c = value; }
        }

        public Quadratic(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double GetValue(double x)
        {
            return A * x * x + B * x + C;
        }
        public IFunction GetDerivative()
        {
            return new LinearFunction(2 * A, B);
        }

        
    }
}
