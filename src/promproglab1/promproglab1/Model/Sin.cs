using System;

namespace promproglab1.Model
{
    class Sin : Function
    {
        public double A { get; init; }

        public Sin(double a)
        {
            A = a;
        }

        public override Function GetDerivative()
        {
            return new Cos(1);
        }

        public override double GetValue(double x)
        {
            return Math.Sin(x);
        }

        public override bool Equals(object obj)
        {
            if (obj is not Sin other)
                return false;
            return A == other.A;
        }

        public override string ToString()
        {
            return ($"y = {A}*Sin(X)");
        }

        public override int GetHashCode()
        {
            return A.GetHashCode();
        }
    }
}
