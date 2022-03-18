namespace promproglab1.Model
{
    internal class LinearFunction : Function
    {

        public double K { get; init; }
        public double B { get; init; }

        public LinearFunction(double k, double b)
        {
            K = k;
            B = b;
        }

        public override double GetValue(double x)
        {
            return K * x + B;
        }

        public override Function GetDerivative()
        {
            return new Const(K);
        }

        public override bool Equals(object obj)
        {
            if (obj is not LinearFunction other)
            return false;
            return K == other.K && B == other.B;
        }

        public override string ToString()
        {
            return ($"y = {K}*x+{B}");
        }

        public override int GetHashCode()
        {
            return K.GetHashCode() ^ B.GetHashCode();
        }
    }
}
