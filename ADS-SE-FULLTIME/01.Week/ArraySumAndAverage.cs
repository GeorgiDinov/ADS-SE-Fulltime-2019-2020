using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Week
{
    internal class ArraySumAndAverage
    {

        public static int SumAllElementsInSingleDimentionalArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public static double GetAverageOfSingleDimentionalArray(int[] array)
        {
            int sum = SumAllElementsInSingleDimentionalArray(array);
            return sum / array.Length;
        }

    }
}
