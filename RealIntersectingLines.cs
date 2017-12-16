using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Order_Curves
{
    class RealIntersectingLines : AbstractCurve
    {
        private double a;
        private double b;
        public RealIntersectingLines(double delta, double lambda1, double lambda2): base (delta, 0, 0, 0, lambda1, lambda2) { }
        public override void GetData()
        {
            Console.WriteLine("Тип кривой: вырожденная гипербола, две пересекающиеся прямые");

            a = Math.Sqrt(-delta / (D * lambda1));
            b = Math.Sqrt(delta / (D * lambda2));

            Console.WriteLine("Каноническое уравнение: x^2/{0:0.00} - y^2/{1:0.00} = 0", a * a, b * b);
            Console.WriteLine("График: пересекающиеся прямые у = х и у = -х");

        }
    }
}
