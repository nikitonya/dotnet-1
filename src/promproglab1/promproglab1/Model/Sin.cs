using System;

namespace PromProgLab1.Model
{
    public class Sin : Function
    {
        public double A { get; init; }

        public Sin() { }
        public Sin(double a)
        {
            A = a;
        }

        public override Function GetDerivative()
        {
            return new Cos(A);
        }

        public override double GetValue(double x)
        {
            return A * Math.Sin(x);
        }

        public override bool Equals(object obj)
        {
            if (obj is not Sin other)
                return false;
            return A == other.A;
        }

        public override string ToString()
        {
            return $"y = {A}*Sin(X)";
        }

        public override int GetHashCode()
        {
            return A.GetHashCode();
        }
    }
}
