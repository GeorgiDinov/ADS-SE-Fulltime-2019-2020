using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Week
{
    internal class MainWeekThree
    {

        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 3, -1, 12, 44, 8, 6, 2 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine();
            BubbleSort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine();

            ToNumericalSystem.Num10toOtherBasis();

            //int[] numbers = new int[] { 15, 75, 125, 360, 425 };
            //string[] binaryNumbers = new string[numbers.Length];
            //for (int i = 0; i < binaryNumbers.Length; i++)
            //{
            //    binaryNumbers[i] = ToBinaryString(numbers[i]);
            //}

            //for (int i = 0; i < binaryNumbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i] + " = " + binaryNumbers[i]);
            //}

            //for (int i = 0; i < binaryNumbers.Length; i++)
            //{
            //    Console.WriteLine(binaryNumbers[i] + " = " + ToDecimalNumber(binaryNumbers[i]));
            //}

        }

        private static void BubbleSort(int[] array)
        {
            for (int last = array.Length - 1; last > 0; last--)
            {
                for (int i = 0; i < last; i++)
                {
                    int leftElementIndex = i;
                    int rightElementIndex = i + 1;
                    if (array[leftElementIndex] > array[rightElementIndex])
                    {
                        int temp = array[leftElementIndex];
                        array[leftElementIndex] = array[rightElementIndex];
                        array[rightElementIndex] = temp;
                    }
                }
            }
        }


        private static string GetArrayAsString(int[] array)
        {
            string arrayString = "";
            for (int i = 0; i < array.Length; i++)
            {
                arrayString += (i < array.Length - 1) ? array[i] + ", " : array[i] + "";
            }
            return "[" + arrayString + "]";
        }

        private static string ToBinaryString(int decimalNumber)
        {
            string result = "";
            while (decimalNumber > 0)
            {
                int reminder = decimalNumber % 2;
                result = reminder + result;
                decimalNumber = decimalNumber / 2;
            }
            return result;
        }

        private static long ToDecimalNumber(string binaryRepresentation)
        {
            long result = 0;
            int power = binaryRepresentation.Length - 1;
            for (int i = 0; i < binaryRepresentation.Length; i++)
            {
                long digit = long.Parse(binaryRepresentation.Substring(i, 1));
                if (digit != 0)
                {
                    result += (long)Math.Pow(2, power);
                }
                power--;
            }
            return result;
        }





        private static int getFactorialOfN(int n)
        {
            //https://jacopretorius.net/2010/01/multithreading-example-in-c.html
            if (n == 1)
            {
                return n;
            }
            return n * getFactorialOfN(n - 1);
        }

        private static int getNthFibonacci(int nthFib)
        {
            if (nthFib <= 1)
            {
                return nthFib;
            }

            return getNthFibonacci(nthFib - 1) + getNthFibonacci(nthFib - 2);
        }

        private static void printNumber(int number)
        {
            if (number > 5)
            {
                return;
            }
            Console.Write(number + " ");
            printNumber(number + 1);
        }

        private static void printNumberLoop(int number)
        {
            while (number <= 5)
            {
                Console.Write(number + " ");
                number++;
            }
        }

    }
}
