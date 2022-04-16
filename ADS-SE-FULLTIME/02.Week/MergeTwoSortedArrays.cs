using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Week
{
    class MergeTwoSortedArrays
    {


        public static int[] MergeTwoSortedArraysInThirdArray_V1(int[] leftArray, int[] rightArray)
        {
            int resultArrayLength = leftArray.Length + rightArray.Length;
            int[] resultArray = new int[resultArrayLength];

            int leftArrayCursor = 0;
            int rightArrayCursor = 0;
            int resultArrayCursor = 0;

            while (leftArrayCursor < leftArray.Length && rightArrayCursor < rightArray.Length)
            {
                if (leftArray[leftArrayCursor] < rightArray[rightArrayCursor])
                {
                    resultArray[resultArrayCursor] = leftArray[leftArrayCursor];
                    leftArrayCursor++;
                    resultArrayCursor++;
                }
                else
                {
                    resultArray[resultArrayCursor] = rightArray[rightArrayCursor];
                    rightArrayCursor++;
                    resultArrayCursor++;
                }
            }

            while (leftArrayCursor < leftArray.Length)
            {
                resultArray[resultArrayCursor] = leftArray[leftArrayCursor];
                leftArrayCursor++;
                resultArrayCursor++;
            }

            while (rightArrayCursor < rightArray.Length)
            {
                resultArray[resultArrayCursor] = rightArray[rightArrayCursor];
                rightArrayCursor++;
                resultArrayCursor++;
            }

            return resultArray;
        }


        public static int[] MergeTwoSortedArraysInThirdArray_V1_1(int[] leftArray, int[] rightArray)
        {
            int resultArrayLength = leftArray.Length + rightArray.Length;
            int[] resultArray = new int[resultArrayLength];

            int leftArrayCursor = 0;
            int rightArrayCursor = 0;
            int resultArrayCursor = 0;

            while (leftArrayCursor < leftArray.Length && rightArrayCursor < rightArray.Length)
            {
                if (leftArray[leftArrayCursor] < rightArray[rightArrayCursor])
                {
                    resultArray[resultArrayCursor++] = leftArray[leftArrayCursor++];
                }
                else
                {
                    resultArray[resultArrayCursor++] = rightArray[rightArrayCursor++];
                }
            }

            while (leftArrayCursor < leftArray.Length)
            {
                resultArray[resultArrayCursor++] = leftArray[leftArrayCursor++];
            }

            while (rightArrayCursor < rightArray.Length)
            {
                resultArray[resultArrayCursor++] = rightArray[rightArrayCursor++];
            }

            return resultArray;
        }


        public static int[] MergeTwoSortedArraysInThirdArray_V2(int[] leftArray, int[] rightArray)
        {
            int resultArrayLength = leftArray.Length + rightArray.Length;
            int[] resultArray = new int[resultArrayLength];

            int leftArrayCursor = 0;
            int rightArrayCursor = 0;
            int resultArrayCursor = 0;

            while (resultArrayCursor < resultArray.Length)
            {
                if (leftArrayCursor >= leftArray.Length)
                {
                    resultArray[resultArrayCursor] = rightArray[rightArrayCursor];
                    rightArrayCursor++;
                }
                else if (rightArrayCursor >= rightArray.Length)
                {
                    resultArray[resultArrayCursor] = leftArray[leftArrayCursor];
                    leftArrayCursor++;
                }
                else if (leftArray[leftArrayCursor] < rightArray[rightArrayCursor])
                {
                    resultArray[resultArrayCursor] = leftArray[leftArrayCursor];
                    leftArrayCursor++;
                }
                else
                {
                    resultArray[resultArrayCursor] = rightArray[rightArrayCursor];
                    rightArrayCursor++;
                }

                resultArrayCursor++;
            }

            return resultArray;
        }


    }
}
