using System.Xml.Serialization;

namespace PromProgLab1.Model
{
    [XmlInclude(typeof(Const))]
    [XmlInclude(typeof(LinearFunction))]
    [XmlInclude(typeof(Quadratic))]
    [XmlInclude(typeof(Sin))]
    [XmlInclude(typeof(Cos))]
    public abstract class Function
    {
        public abstract double GetValue(double x);

        public abstract Function GetDerivative();

        public abstract override bool Equals(object obj);

        public abstract override string ToString();

        public abstract override int GetHashCode();
        
    }
}
