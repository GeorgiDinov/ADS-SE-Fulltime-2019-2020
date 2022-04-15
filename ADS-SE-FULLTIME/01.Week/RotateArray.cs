using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Week
{
    internal class RotateArray
    {


        public static void RotateSingleDimentionalArrayV1(int[] array)
        {
            int last = array.Length - 1;
            for (int first = 0; first < array.Length / 2; first++)
            {
                int temp = array[first];
                array[first] = array[last];
                array[last--] = temp;
            }
        }

        public static void RotateSingleDimentionalArrayV2(int[] array)
        {
            for (int first = 0, last = array.Length - 1; first < array.Length / 2; first++, last--)
            {
                int temp = array[first];
                array[first] = array[last];
                array[last] = temp;
            }
        }

        public static void RotateSingleDimentionalArrayV2_1(int[] array)
        {
            for (int first = 0, last = array.Length - 1; first < array.Length / 2; first++, last--)
            {
                Swap(array, first, last);
            }
        }

        public static void RotateSingleDimentionalArrayV3(int[] array)
        {
            int first = 0, last = array.Length - 1;
            while (first < array.Length / 2)
            {
                int temp = array[first];
                array[first++] = array[last];
                array[last--] = temp;
            }
        }

        public static void RotateSingleDimentionalArrayV3_1(int[] array)
        {
            int first = 0, last = array.Length - 1;
            while (first < array.Length / 2)
            {
                Swap(array, first, last);
                first++;
                last--;
            }
        }


        private static void Swap(int[] array, int left, int right)
        {
            if (left == right)
            {
                return;
            }

            if (IsIndexOutOfBounds(array, left))
            {
                return;//process with custom exception or other logic
            }

            if (IsIndexOutOfBounds(array, right))
            {
                return;//process with custom exception or other logic
            }

            if (array[left] == array[right])
            {
                return;
            }

            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }

        private static bool IsIndexInBounds(int[] array, int index)
        {
            return index >= 0 && index < array.Length;
        }

        private static bool IsIndexOutOfBounds(int[] array, int index)
        {
            return index < 0 && index >= array.Length;
        }

    }
}
