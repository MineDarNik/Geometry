using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Order_Curves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите через пробел коэффициенты кривой вида ");
            Console.WriteLine("A*x^2 + C*y^2 + B*x*y + D*x + E*y + H = 0");
            Console.WriteLine();
            var line = Console.ReadLine();
            var c = line.Split(' ');

            double a11, a22, a12, a13, a23, a33;
            a11 = Double.Parse(c[0]);
            a22 = Double.Parse(c[1]);
            a12 = Double.Parse(c[2]);
            a13 = Double.Parse(c[3]);
            a23 = Double.Parse(c[4]);
            a33 = Double.Parse(c[5]);

            var curve = new Curves(a11, a22, a12, a13, a23, a33);
            curve.GetData();
            Console.ReadKey();
        }
    }
}
