namespace promproglab1.Model
{
    internal class QuadraticBase
    {

        public double GetDerivative() => new LinearFunction(2 * _a, _b);
    }
}