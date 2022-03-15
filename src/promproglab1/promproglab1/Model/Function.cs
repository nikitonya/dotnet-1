namespace promproglab1.Model
{
    interface IFunction
    {
        public double GetValue(double x);

        public IFunction GetDerivative();

    }
}
