using System;

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

        public double GetValue(double x)
        {
            return _a * x * x + _b * x + _c;
        }
        public IFunction GetDerivative()
        {
            return new LinearFunction(2 * _a, _b);
        }

        
    }
}
