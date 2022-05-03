using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _04.Week
{
    internal class MainWeekFour
    {

        static void Main(string[] args)
        {

            //Console.WriteLine("Array = " + GetArrayAsString(array));

            //int[] searchArray = new int[] { 5, 9, 14, 33, 78, 128 };
            //int numberToSearchFor = 128;
            //int position = BinarySearch(searchArray, numberToSearchFor);
            //Console.WriteLine("Array = " + GetArrayAsString(searchArray));
            //if (position != -1)
            //{
            //    Console.WriteLine("Found " + numberToSearchFor + " at " + (position + 1) + " position.");
            //}
            //else
            //{
            //    Console.WriteLine(numberToSearchFor + " not found.");
            //}

            int[] array = GetInitilaziedArrayWithLenght(80000);
            //Console.WriteLine("Unsorted       = " + GetArrayAsString(array));
            long start = DateTime.Now.Millisecond;
            Stopwatch stop = new Stopwatch();
            stop.Start();
            TestSort(array);
            stop.Stop();
            long end = DateTime.Now.Millisecond;
            //Console.WriteLine("Test Sort      = " + GetArrayAsString(array));
            Console.WriteLine("Time = " + stop.ElapsedMilliseconds);

            int[] array2 = GetInitilaziedArrayWithLenght(80000);
            //Console.WriteLine("Unsorted       = " + GetArrayAsString(array));
            long start2 = DateTime.Now.Millisecond;
            Stopwatch stop2 = new Stopwatch();
            stop2.Start();
            SelectionSort(array2);
            stop2.Stop();
            long end2 = DateTime.Now.Millisecond;
            //Console.WriteLine("Test Sort      = " + GetArrayAsString(array));
            Console.WriteLine("Time = " + stop2.ElapsedMilliseconds);

            int[] array3 = GetInitilaziedArrayWithLenght(80000);
            //Console.WriteLine("Unsorted       = " + GetArrayAsString(array));
            long start3 = DateTime.Now.Millisecond;
            Stopwatch stop3 = new Stopwatch();
            stop3.Start();
            GeorginaSort(array3);
            stop3.Stop();
            long end3 = DateTime.Now.Millisecond;
            //Console.WriteLine("Test Sort      = " + GetArrayAsString(array));
            Console.WriteLine("Time = " + stop3.ElapsedMilliseconds);

            int[] array4 = GetInitilaziedArrayWithLenght(80000);
            //Console.WriteLine("Unsorted       = " + GetArrayAsString(array));
            long start4 = DateTime.Now.Millisecond;
            Stopwatch stop4 = new Stopwatch();
            stop4.Start();
            Array.Sort(array3);
            stop4.Stop();
            long end4 = DateTime.Now.Millisecond;
            //Console.WriteLine("Test Sort      = " + GetArrayAsString(array));
            Console.WriteLine("Time = " + stop4.ElapsedMilliseconds);

            Console.ReadKey();
        }


        private static void TestSort(int[] array)
        {
            int cursorStart = 0;
            int cursorEnd = array.Length - 1;
            while (cursorStart < cursorEnd)
            {
                int currentMax = cursorStart;
                int currentMin = cursorEnd;
                for (int i = cursorStart; i <= cursorEnd; i++)
                {
                    if (array[i] > array[currentMax]) currentMax = i;
                    else if (array[i] < array[currentMin]) currentMin = i;
                }
                Swap(array, currentMax, cursorEnd);
                // If smallest element was at the end, it was switched so update its index
                if (cursorEnd == currentMin)
                {
                    currentMin = currentMax;
                }
                Swap(array, currentMin, cursorStart);
                cursorEnd--;
                cursorStart++;
            }
        }

        private static void GeorginaSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - i; i++)
            {
                int currentMin = int.MaxValue;
                int currentMinIndex = i;

                int currentMax = int.MinValue;
                int currentMaxIndex = arr.Length - i;

                for (int j = i; j < arr.Length - i; j++)
                {
                    int currentDigit = arr[j];

                    if (currentDigit > currentMax)
                    {
                        currentMax = currentDigit;
                        currentMaxIndex = j;
                    }
                    if (currentDigit < currentMin)
                    {
                        currentMin = currentDigit;
                        currentMinIndex = j;
                    }
                }

                int firstTemp = arr[i];
                int secondTemp = arr[arr.Length - i - 1];

                arr[i] = currentMin;
                arr[currentMinIndex] = firstTemp;

                arr[arr.Length - i - 1] = currentMax;
                arr[currentMaxIndex] = secondTemp;
            }
        }

        private static int min(int[] array, int leftBound, int rightBound)
        {
            int min = leftBound;
            for (int i = 0; i <= rightBound; i++)
            {
                if (array[i] < array[min])
                {
                    min = i;
                }
            }
            return min;
        }

        private static int max(int[] array, int leftBound, int rightBound)
        {
            int max = leftBound;
            for (int i = 0; i <= rightBound; i++)
            {
                if (array[i] < array[max])
                {
                    max = i;
                }
            }
            return max;
        }


        private static void SelectionSort(int[] array)
        {
            for (int first = 0; first < array.Length; first++)
            {
                int currentMin = first;
                for (int current = first + 1; current < array.Length; current++)
                {
                    if (array[current] < array[currentMin])
                    {
                        currentMin = current;
                    }
                }
                Swap(array, currentMin, first);
            }
        }

        private static void SelectionSortV2(int[] array)
        {
            for (int last = array.Length - 1; last > 0; last--)
            {
                int currentMax = last;
                for (int current = 0; current < last; current++)
                {
                    if (array[current] > array[currentMax])
                    {
                        currentMax = current;
                    }
                }
                Swap(array, currentMax, last);
            }
        }

        private static void BubbleSort(int[] array)
        {
            for (int last = array.Length - 1; last > 0; last--)
            {
                for (int current = 0; current < last; current++)
                {
                    int next = current + 1;
                    if (array[current] > array[next])
                    {
                        Swap(array, current, next);
                    }
                }
            }
        }

        private static void Swap(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex == rightIndex)
            {
                return;
            }

            if (array[leftIndex] == array[rightIndex])
            {
                return;
            }

            int temp = array[leftIndex];
            array[leftIndex] = array[rightIndex];
            array[rightIndex] = temp;
        }


        private static int BinarySearch(int[] arrayToSearchIn, int numberToSearchFor)
        {
            int first = 0;
            int last = arrayToSearchIn.Length - 1;
            while (first <= last)
            {
                int mid = (first + last) / 2;

                if (numberToSearchFor == arrayToSearchIn[mid])
                {
                    return mid;
                }

                if (numberToSearchFor > arrayToSearchIn[mid])
                {
                    first = mid + 1;
                }
                else
                {
                    last = mid - 1;
                }
            }
            return -1;
        }

        private static int LinearSearch(int[] arrayToSearchIn, int numberToSearchFor)
        {
            for (int i = 0; i < arrayToSearchIn.Length; i++)
            {
                if (arrayToSearchIn[i] == numberToSearchFor)
                {
                    return i;
                }
            }
            return -1;
        }

        private static int[] GetInitilaziedArrayWithLenght(int lenght)
        {
            Random random = new Random();
            int[] array = new int[lenght];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 100);
            }
            return array;
        }

        private static string GetArrayAsString(int[] array)
        {
            string result = "";
            for (int i = 0; i < array.Length; i++)
            {
                result += (i < array.Length - 1) ? array[i] + ", " : array[i] + "";
            }
            return "[" + result + "]";
        }

    }
}
