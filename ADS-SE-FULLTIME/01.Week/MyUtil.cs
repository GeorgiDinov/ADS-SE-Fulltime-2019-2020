using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Week
{
    internal class MyUtil
    {

        public static void PrintSingleDimentionalArray(int[] array)
        {
            Console.WriteLine("Array " + GetArrayAsString(array));
        }

        public static string GetArrayAsString(int[] array)
        {
            string arrayString = "[";
            for (int i = 0; i < array.Length; i++)
            {
                arrayString += (i < array.Length - 1) ? array[i] + ", " : array[i] + "]";
            }
            return arrayString;
        }

    }
}
