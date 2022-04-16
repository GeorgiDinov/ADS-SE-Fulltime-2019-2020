using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Week
{
    class PrimeNumber
    {

        public static void PrintPrimeNumbersUpTo(int upperBoundary)
        {
            for (int i = 2; i < upperBoundary; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();    
        }


        private static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++) // possible place for optimization e.g. number/2; (long) Math.Sqrt(number);
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }


}
