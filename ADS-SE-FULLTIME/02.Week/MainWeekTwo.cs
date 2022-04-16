using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Week
{
    internal class MainWeekTwo
    {
        static void Main(string[] args)
        {
            //int[] leftArray = new int[] { 1, 4, 7, 8, 12 };
            //int[] rightArray = new int[] { 0, 2, 3, 5, 9, 15, 16, 18 };


            //Console.WriteLine("Left Array = " + GetArrayAsString(leftArray));
            //Console.WriteLine("Right Array = " + GetArrayAsString(rightArray));

            //int[] resultArray = MergeTwoSortedArrays.MergeTwoSortedArraysInThirdArray_V1(leftArray, rightArray);
            //Console.WriteLine("Result Array V1   = " + GetArrayAsString(resultArray));

            //resultArray = MergeTwoSortedArrays.MergeTwoSortedArraysInThirdArray_V1_1(leftArray, rightArray);
            //Console.WriteLine("Result Array V1_1 = " + GetArrayAsString(resultArray));

            //resultArray = MergeTwoSortedArrays.MergeTwoSortedArraysInThirdArray_V2(leftArray, rightArray);
            //Console.WriteLine("Result Array V2   = " + GetArrayAsString(resultArray));

            //**************************************************************************************************************

            //int primeNumbersUpperBoundary = 50;
            //PrimeNumber.PrintPrimeNumbersUpTo(primeNumbersUpperBoundary);
            //PrimeNumberErathosteneSieve.EratastenPrimes(primeNumbersUpperBoundary);


            //**************************************************************************************************************

            //int fibNumBoundary = 20;
            //FibonachiLineArray.GetFibonachiLineUpTo(fibNumBoundary);
            //int[] fibonachiLine = FibonachiLineArray.GetFibonachiLineUpTo(fibNumBoundary);
            //Console.WriteLine("First " + fibNumBoundary + " fibonacci numbers = " + GetArrayAsString(fibonachiLine));
            //Console.WriteLine(fibNumBoundary+ "th fibonachi = "+ FibonachiLineArray.GetNthFibonachi(fibNumBoundary));

            //**************************************************************************************************************

            //int[,] matrix = new int[5, 5];
            //TwoDimentionalArray.InitTwoDimentionalArray(matrix);
            //Console.WriteLine(TwoDimentionalArray.GetTwoDimentionalArrayAsString(matrix));

            //matrix = new int[,] {
            //    {1,2,3,4},
            //    {5,6,7,8}
            //};
            //Console.WriteLine(TwoDimentionalArray.GetTwoDimentionalArrayAsString(matrix));

            //**************************************************************************************************************
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

    }
}
