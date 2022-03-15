namespace promproglab1.Model
{
    internal class Const : IFunction
    {
        private double _a;

        public double A
        {
            get { return _a; }
            set { _a = value; }
        }

        public Const(double a)
        {
            _a = a;
        }

        public double GetValue(double x)
        {
            return A;
        }

        public IFunction GetDerivative()
        {
            return new Const(0);
        }



    }
}
