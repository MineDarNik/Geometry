using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Order_Curves
{
    class Ellipse : AbstractCurve
    {
        private double e;
        private double p;
        private double a;
        private double b;
        public Ellipse(double delta, double D, double I, double B, double lambda1, double lambda2) : base(delta, D, I, B, lambda1, lambda2) { }

        public override void GetData()
        {
            Console.WriteLine("Тип кривой: эллипс");

            e = Math.Sqrt(1 - (b * b) / (a * a));

            if (e == 0) { Console.WriteLine("Частный случай эллипса: окружность"); }

            a = Math.Sqrt(-delta / (lambda2 * lambda2 * lambda1));
            b = Math.Sqrt(-delta / (lambda1 * lambda1 * lambda2));

            Console.WriteLine("Каноническое уравнение: x^2/{0:0.00} + y^2/{1:0.00} = 1", a*a, b*b);
            Console.WriteLine("Эксцентриситет: {0:0.00}", e);

            p = b*b / a;

            Console.WriteLine("Фокальный параметр: {0:0.00}", p);
            Console.WriteLine("Фокальное расстояние: {0:0.00}", a * e);
            Console.WriteLine("Уравнения директрис: x = {0:0.00} , x = {1:0.00}", -a / e, a / e);
            Console.WriteLine("Координаты фокуса: ({0:0.00}, 0), ({1:0.00}, 0)", -a * e, a * e);
        }
        private void PrintCanonicalEquation()
        {
            
        }

    }   
}
