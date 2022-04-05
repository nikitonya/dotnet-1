using System;

namespace promproglab1.Model
{
    public class Cos : Function
    {
        public double A { get; init; }

        public Cos() { }
        public Cos(double a)
        {
            A = a;
        }

        public override Function GetDerivative()
        {
            return new Sin(-A);
        }

        public override double GetValue(double x)
        {
            return A*Math.Cos(x);
        }

        public override bool Equals(object obj)
        {
            if (obj is not Cos other)
                return false;
            return A == other.A;
            
        }

        public override string ToString()
        {
            return ($"y = {A}*Cos(X)");
        }

        public override int GetHashCode()
        {
            return A.GetHashCode();
        }
    }
}
