using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Order_Curves
{
    class Determinant
    {
        private static double Det2x2(double[,] matrix)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[1, 0] * matrix[0, 1];
        }
        public static double Calculate(double[,] matrix)
        {
            int size = matrix.Length;
            if (size == 4)
            {
                return Det2x2(matrix);
            }
            else
            {
                return matrix[0, 0] * Det2x2(new double[,]  { { matrix[1, 1], matrix[1, 2] },
                                                              { matrix[2, 1], matrix[2, 2] } })
                      - matrix[0, 1] * Det2x2(new double[,] { { matrix[1, 0], matrix[1, 2] },
                                                              { matrix[2, 0], matrix[2, 2] } })
                      + matrix[0, 2] * Det2x2(new double[,] { { matrix[1, 0], matrix[1, 1] },
                                                              { matrix[2, 0], matrix[2, 1] } });

            }
        }
    }
}
