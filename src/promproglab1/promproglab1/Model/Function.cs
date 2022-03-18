namespace promproglab1.Model
{
    abstract class Function
    {
        public abstract double GetValue(double x);

        public abstract Function GetDerivative();

        public abstract override bool Equals(object obj);

        public abstract override string ToString();

    }
}
