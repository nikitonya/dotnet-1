namespace PromProgLab1.Model
{
    public class Const : Function
    {
        public double A { get; init; }

        public Const() { }
        public Const(double a)
        {
            A = a;
        }

        public override double GetValue(double x)
        {
            return A;
        }

        public override Function GetDerivative()
        {
            return new Const(0);
        }
        
        public override bool Equals(object obj)
        {
            if (obj is not Const other)
                return false;  
            return A == other.A;
        }

        public override string ToString()
        {
            return $"y = {A}";
        }
        
        public override int GetHashCode()
        {
            return A.GetHashCode();
        }
    }
}
