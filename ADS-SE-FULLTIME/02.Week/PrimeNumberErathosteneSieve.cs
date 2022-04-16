using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Week
{
    class PrimeNumberErathosteneSieve
    {

        public static void EratastenPrimes(int primesBoundary)
        {
            bool[] primes = new bool[primesBoundary + 1];

            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    for (int j = i + i; j < primes.Length; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }

            for (int i = 2; i < primes.Length; i++)
            {

                if (primes[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }


    }
}
