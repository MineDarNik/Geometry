using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Order_Curves
{
    class ImaginaryParallelLines : AbstractCurve
    {
        public ImaginaryParallelLines() : base(0, 0, 0, 0, 0, 0) { }
        public override void GetData()
        {
            Console.WriteLine("Тип кривой: вырожденная парабола, две мнимых параллельных прямых");
            Console.WriteLine("График: ни одной вещественной точки");
        }
    }
}
