using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Order_Curves
{
    class Curves
    {
        private double a11, a22, a12, a13, a23, a33;
        private double lambda1, lambda2;
        private double delta;
        private double D;
        private double I;
        private double B;
        private AbstractCurve curve;


        public Curves(double a11, double a22, double a12, double a13, double a23, double a33)
        {
            this.a11 = a11;
            this.a22 = a22;
            this.a12 = a12/2;
            this.a13 = a13/2;
            this.a23 = a23/2;
            this.a33 = a33;
            delta = CalculateDelta();
            D = CalculateD();
            I = CalculateI();
            B = CalculateB();
            var lambdas = CalculateLambda();
            lambda1 = lambdas.Item1;
            lambda2 = lambdas.Item2;

            if (delta != 0) //кривая невырождена
            {
                if (D > 0 && delta * I < 0) { curve = new Ellipse(delta, D, I, B, lambda1, lambda2); }
                if (D > 0 && delta * I > 0) { curve = new ImagynaryEllipse(delta, D, I, B, lambda1, lambda2); }
                if (D < 0) { curve = new Hyperbola(delta, D, I, B, lambda1, lambda2); } 
            }
            else //кривая вырождена
            {
                if (D > 0) { curve = new RealPoint(delta, D, I, B, lambda1, lambda2); }
                if (D < 0) { curve = new RealIntersectingLines(delta, D, I, B, lambda1, lambda2); }
            }
        }

        public void GetData()
        {
            curve.GetData();
        }

        private double CalculateDelta()
        {
            double result = Determinant.Calculate(new double[,] { {a11, a12, a13 },
                                                                  {a12, a22, a23 },
                                                                  {a13, a23, a33 } });
            return result;
        }
        private double CalculateD()
        {
            double result = Determinant.Calculate(new double[,] { { a11, a12 },
                                                                  { a12, a22 } });
            return result;
        }
        private double CalculateI()
        {
            return a11 + a22;
        }
        private double CalculateB()
        {
            double det1 = Determinant.Calculate(new double[,] { { a11, a13 },
                                                                { a13, a33 }});
            double det2 = Determinant.Calculate(new double[,] { { a22, a23 },
                                                                { a23, a33 }});
            return det1 + det2;
        }
        private Tuple<double, double> CalculateLambda()
        {
            double d = I * I - 4 * D;
            double lambda1 = (I + Math.Sqrt(d)) / 2;
            double lambda2 = (I - Math.Sqrt(d)) / 2;
            return new Tuple<double, double>(lambda1, lambda2);
        } 

    }
}
