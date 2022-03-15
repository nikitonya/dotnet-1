namespace promproglab1.Model
{
    internal class LinearFunction : IFunction
    {
        private double _k;
        public double K
        {
            get { return _k; }
            set { _k = value; }
        }

        private double _b;
        public double B
        {
            get { return _b; }
            set { _b = value; }
        }

        public LinearFunction(double k, double b)
        {
            _k = k;
            _b = b;
        }

        public double GetValue(double x)
        {
            return K * x + B;
        }

        public IFunction GetDerivative()
        {
            return new Const(K);
        }
    }
}
