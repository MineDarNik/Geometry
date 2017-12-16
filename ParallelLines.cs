using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Order_Curves
{
    class ParallelLines : AbstractCurve
    {
        private double p;
        private double a;
        public ParallelLines(double delta, double I, double B) : base(delta, 0, I, B, 0, 0) { }
        public override void GetData()
        {
            p = 1 / I * Math.Sqrt(-delta / I);
            a = p / 2;

            if (B < 0)
            {
                Console.WriteLine("Тип кривой: вырожденная парабола, две параллельные прямые");
                Console.WriteLine("Уравнения прямых: x = {0:0.00} и х = {1:0.00}", a, -a);
            }
            if (B == 0)
            {
                Console.WriteLine("Тип кривой: вырожденная парабола, прямая");
                Console.WriteLine("Уравнения прямых: x = 0");
            }


        }
    }
}
