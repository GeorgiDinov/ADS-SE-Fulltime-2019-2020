using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Week
{
    class FibonachiLineArray
    {


        public static int[] GetFibonachiLineUpTo(int nthFibonachi)
        {
            int[] fibonachiLine = new int[nthFibonachi + 1];
            fibonachiLine[0] = 0;
            fibonachiLine[1] = 1;

            for (int currentFibNumber = 2; currentFibNumber < fibonachiLine.Length; currentFibNumber++)
            {
                int previous = fibonachiLine[currentFibNumber - 1];
                int previousOfThePrevious = fibonachiLine[currentFibNumber - 2];
                int fibNum = previous + previousOfThePrevious;
                fibonachiLine[currentFibNumber] = fibNum;
            }
            return fibonachiLine;
        }

        public static long GetNthFibonachi(int nthFibonachi)
        {
            long[] fibonachiLine = new long[nthFibonachi + 1];
            fibonachiLine[0] = 0;
            fibonachiLine[1] = 1;

            for (int currentFibNumber = 2; currentFibNumber < fibonachiLine.Length; currentFibNumber++)
            {
                long previous = fibonachiLine[currentFibNumber - 1];
                long previousOfThePrevious = fibonachiLine[currentFibNumber - 2];
                long fibNum = previous + previousOfThePrevious;
                fibonachiLine[currentFibNumber] = fibNum;
            }
            return fibonachiLine[nthFibonachi];
        }


    }
}
