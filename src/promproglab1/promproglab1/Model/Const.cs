namespace promproglab1.Model
{
    internal class Const : IFunction
    {
        private double _a;
        public Const(double a)
        {
            _a = a;
        }

        public Const()
        {
        }

        public double GetValue(double x)
        {
            return _a;
        }

        public IFunction GetDerivative()
        {
            return new Const(0);
        }



    }
}
