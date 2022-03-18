using promproglab1.Model;
using System;

namespace promproglab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var con = new Const(5);
            var con2 = new Const(6);
            Console.WriteLine(con.Equals(con2));

            var lin = new LinearFunction(5, 7);
            var lin2 = new LinearFunction(6, 7);
            Console.WriteLine(lin.Equals(lin2));

            var quad = new Quadratic(1, 2, 3);
            var quad2 = new Quadratic(1, 2, 3);
            Console.WriteLine(quad.Equals(quad2));

            var sin = new Sin(5);
            var sin2 = new Sin(5);
            Console.WriteLine(sin.Equals(sin2));

            var cos = new Cos(8);
            var cos2 = new Cos(7);
            Console.WriteLine(cos.Equals(cos2));

            Console.WriteLine(con.ToString());
            Console.WriteLine(lin.ToString());
            Console.WriteLine(quad.ToString());
            Console.WriteLine(sin.ToString());
            Console.WriteLine(cos.ToString());
        }

    }
        
}
