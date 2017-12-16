using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Order_Curves
{
    class RealPoint : AbstractCurve
    {
        private double a;
        private double b;
        public RealPoint(double delta, double lambda1, double lambda2): base (delta, 0, 0, 0, lambda1, lambda2) { }
        public override void GetData()
        {
            Console.WriteLine("Тип кривой: вырожденный эллипс, вещественная точка на пересечении двух мнимых прямых");
            a = Math.Sqrt(-delta / (lambda2 * lambda2 * lambda1));
            b = Math.Sqrt(-delta / (lambda1 * lambda1 * lambda2));
            Console.WriteLine("Каноническое уравнение: x^2/{0:0.00} + y^2/{1:0.00} = 0", a * a, b * b);
            Console.WriteLine("График: точка с координатами (0, 0)");
        }
    }
}
