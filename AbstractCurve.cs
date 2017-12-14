using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Order_Curves
{

    abstract class AbstractCurve
    {
        protected double delta;
        protected double D;
        protected double I;
        protected double B;
        protected double lambda1, lambda2;

        public AbstractCurve(double delta, double D, double I, double B, double lambda1, double lambda2)
        {
            this.delta = delta;
            this.D = D;
            this.I = I;
            this.B = B;
            this.lambda1 = lambda1;
            this.lambda2 = lambda2;
        }


        abstract public void GetData();
    }
}
