using promproglab1.Model;
using System;

namespace promproglab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var con = new Const(5);
            Console.WriteLine(con.GetValue(10));

            var linfunc = new LinearFunction(5, 7);
            Console.WriteLine(linfunc.GetValue(5));

            var sin = new Sin();
            Console.WriteLine(sin.GetDerivative(5));

        }
    }
}
