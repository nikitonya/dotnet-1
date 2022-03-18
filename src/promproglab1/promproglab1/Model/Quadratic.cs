using System;

namespace promproglab1.Model
{
    internal class Quadratic : Function
    {
        public double A { get; init; }
        public double B { get; init; }
        public double C { get; init; }

        public Quadratic(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double GetValue(double x)
        {
            return A * x * x + B * x + C;
        }
        public override Function GetDerivative()
        {
            return new LinearFunction(2 * A, B);
        }

        public override bool Equals(object obj)
        {
            if (obj is not Quadratic other)
                return false;
            return A == other.A && B == other.B && C == other.C;
        }

        public override string ToString()
        {
            return ($"y = {A}*x*x+{B}*x+{C}");
        }
    }
}
