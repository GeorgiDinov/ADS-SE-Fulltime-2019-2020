using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Week
{
    internal class Exercise
    {

        private static Random random = new Random();
        //static void Main(string[] args)
        //{

        //    int[] array = GetArrayWithLenght(7);
        //    //array = new int[] { 10, 14, 20, 36, 56 };
        //    //int number = 56;// random.Next(10, 100);
        //    //Console.WriteLine("Searching for " + number + " in array " + GetArrayAsString(array));
        //    //int result = BinarySearch(array, number);
        //    //if (result != -1)
        //    //{
        //    //    Console.WriteLine("Found " + number + " at position " + result);
        //    //}
        //    //else
        //    //{
        //    //    Console.WriteLine(number + " not found");
        //    //}

        //    Console.WriteLine("Unsorted       = " + GetArrayAsString(array));
        //    SelectionSortV2(array);
        //    //Console.WriteLine("******************************");
        //    Console.WriteLine("Selection Sort = " + GetArrayAsString(array));



        //}


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

        private static void SelectionSort(int[] array)
        {
            for (int last = array.Length - 1; last > 0; last--)
            {
                Console.WriteLine(GetArrayAsString(array));
                int max = last;
                for (int i = 0; i <= last; i++)
                {
                    if (array[i] > array[max])
                    {
                        max = i;
                    }
                }
                Swap(array, max, last);
                Console.WriteLine("max=" + max + ", last=" + last);
                Console.WriteLine(GetArrayAsString(array));
                Console.WriteLine("******************************");
            }
        }

        private static void SelectionSortV2(int[] array)
        {
            for (int first = 0; first < array.Length; first++)
            {
                int min = first;
                for (int i = first + 1; i < array.Length; i++)
                {
                    if (array[i] < array[min])
                    {
                        min = i;
                    }
                }
                Swap(array, min, first);
            }
        }

        private static void Swap(int[] array, int left, int right)
        {
            if (left == right)
            {
                return;
            }

            if (array[left] == array[right])
            {
                return;
            }

            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }

        private static int BinarySearch(int[] arrayToSearchIn, int numberToSearhFor)
        {
            int first = 0;
            int last = arrayToSearchIn.Length - 1;
            while (first <= last)
            {
                int mid = (first + last) / 2;
                if (arrayToSearchIn[mid] == numberToSearhFor)
                {
                    return mid;
                }

                if (arrayToSearchIn[mid] > numberToSearhFor)
                {
                    last = mid - 1;
                }
                else
                {
                    first = mid + 1;
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

        private static int[] GetArrayWithLenght(int arrayLenght)
        {
            int[] array = new int[arrayLenght];
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
