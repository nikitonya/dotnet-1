using System;

namespace promproglab1.Model
{
    internal class Cos : Function
    {
        public double A { get; init; }

        public Cos(double a)
        {
            A = a;
        }

        public override Function GetDerivative()
        {
            return new Sin(-1);
        }

        public override double GetValue(double x)
        {
            return Math.Cos(x);
        }

        public override bool Equals(object obj)
        {
            if (obj is not Cos other)
                return false;
            return A == other.A;
            
        }

        public override string ToString()
        {
            return ($"y = Cos({A})");
        }

        public override int GetHashCode()
        {
            return A.GetHashCode();
        }
    }
}
