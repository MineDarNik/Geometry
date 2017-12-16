using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Order_Curves
{
    class ImagynaryEllipse : AbstractCurve
    {
        public ImagynaryEllipse() : base(0, 0, 0, 0, 0, 0) { }

        public override void GetData()
        {
            Console.WriteLine("Тип кривой: мнимый эллипс (ни одной вещественной точки)");
        }
    }
}
