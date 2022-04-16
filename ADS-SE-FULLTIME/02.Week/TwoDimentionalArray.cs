using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Week
{
    class TwoDimentionalArray
    {
        private static Random random = new Random();


        public static void InitTwoDimentionalArray(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(10, 99);
                }
            }
        }

        public static string GetTwoDimentionalArrayAsString(int[,] matrix)
        {
            string matrixString = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrixString += "[";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrixString += (j < matrix.GetLength(1) - 1) ? matrix[i, j] + ", " : matrix[i, j] + "";
                }
                matrixString += "]\n";
            }

            return matrixString;
        }
    }
}
