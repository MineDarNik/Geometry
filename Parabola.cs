using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Order_Curves
{
    class Parabola : AbstractCurve
    {
        private double p;
        public Parabola (double delta, double D, double I, double B, double lambda1, double lambda2): base(delta, D, I, B, lambda1, lambda2) { }
        public override void GetData()
        {
            Console.WriteLine("Тип кривой: парабола");

            p = 1 / I * Math.Sqrt(-delta / I);

            Console.WriteLine("Каноническое уравнение: y^2 = 2*{0:0.00}*x", p);
            Console.WriteLine("Эксцентриситет: 1");
            Console.WriteLine("Фокальный параметр: {0:0.00}", p);
            Console.WriteLine("Фокальное расстояние: {0:0.00}", p / 2);
            Console.WriteLine("Уравнения директрисы: x = {0:0.00}", -p / 2);
            Console.WriteLine("Координаты фокуса: ({0:0.00}, 0), ({1:0.00}, 0)", -p / 2, p / 2);
        }
    }
}
