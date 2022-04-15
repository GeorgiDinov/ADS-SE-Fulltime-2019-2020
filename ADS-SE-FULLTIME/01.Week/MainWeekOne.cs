using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Week
{
    internal class MainWeekOne
    {
        static void Main(string[] args)
        {
            // Interview task examples, uncoment, test and see the code in the class
            //int[] array = new int[] { 12, 32, 2, 10 };
            //int[] array2 = new int[] { 1, 0, 0, 0, 0, 1 };
            //InterviewTaskExample.EqualSumCheck(array);
            //InterviewTaskExample.EqualSumCheckAllPositions(array);
            //InterviewTaskExample.EqualSumCheckAllPositions(array2);
            //Console.WriteLine("Corner cases tests");
            //int[] tstArray = null;
            //InterviewTaskExample.EqualSumCheck(tstArray);
            //Console.WriteLine("**************************");
            //tstArray = new int[0];
            //InterviewTaskExample.EqualSumCheck(tstArray);
            //Console.WriteLine("**************************");
            //tstArray = new int[] { };
            //InterviewTaskExample.EqualSumCheck(tstArray);
            //Console.WriteLine("**************************");
            //tstArray = new int[] { 5 };
            //InterviewTaskExample.EqualSumCheck(tstArray);
            //Console.WriteLine("**************************");
            //tstArray = new int[] { 5, 5 };
            //InterviewTaskExample.EqualSumCheck(tstArray);
            //Console.WriteLine("**************************");
            //tstArray = new int[] { 0, 5 };
            //InterviewTaskExample.EqualSumCheck(tstArray);
            //Console.WriteLine("**************************");
            //tstArray = new int[] { 5, 0 };
            //InterviewTaskExample.EqualSumCheck(tstArray);

            //**********************************************************************************

            //Min and max values in array
            //int[] array = new int[] { 1, 2, 3, 4, 5 };
            //int min = ArrayMinAndMax.GetMinValueInSingleDimentionalArray(array);
            //int max = ArrayMinAndMax.GetMaxValueInSingleDimentionalArray(array);
            //string message = "Array " + MyUtil.GetArrayAsString(array) + " has min=" + min + " and max=" + max + " values";
            //Console.WriteLine(message);

            //**********************************************************************************

            //string arrayMessage = "Array ";

            //int[] array = new int[] { 1, 2, 3, 4, 5 };
            //MyUtil.PrintSingleDimentionalArray(array);

            //RotateArray.RotateSingleDimentionalArrayV1(array);
            //Console.WriteLine(arrayMessage + MyUtil.GetArrayAsString(array) + " rotated with V1");

            //RotateArray.RotateSingleDimentionalArrayV2(array);
            //Console.WriteLine(arrayMessage + MyUtil.GetArrayAsString(array) + " rotated with V2");

            //RotateArray.RotateSingleDimentionalArrayV2_1(array);
            //Console.WriteLine(arrayMessage + MyUtil.GetArrayAsString(array) + " rotated with V2_1");

            //RotateArray.RotateSingleDimentionalArrayV3(array);
            //Console.WriteLine(arrayMessage + MyUtil.GetArrayAsString(array) + " rotated with V3");

            //RotateArray.RotateSingleDimentionalArrayV3_1(array);
            //Console.WriteLine(arrayMessage + MyUtil.GetArrayAsString(array) + " rotated with V3_1");

            //**********************************************************************************

            //int[] array = new int[] { 1, 2, 3, 4, 5 };
            //int sum = ArraySumAndAverage.SumAllElementsInSingleDimentionalArray(array);
            //double avg = ArraySumAndAverage.GetAverageOfSingleDimentionalArray(array);
            //Console.WriteLine(MyUtil.GetArrayAsString(array) + " has sum=" + sum + " and  avg= " + avg);

            //**********************************************************************************

            //swap using third(temporary) variable
            int a = 5;
            int b = 10;
            Console.WriteLine("'a' & 'b' before swap with temp variable: a=" + a + ", b=" + b);

            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("'a' & 'b'  after swap with temp variable: a=" + a + ", b=" + b);

            Console.WriteLine("****************************************************************");

            //swap using aritmetic operations
            a = 20;
            b = 30;
            Console.WriteLine("'a' & 'b' before swap with aritmetic operation: a=" + a + ", b=" + b);

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("'a' & 'b'  after swap with aritmetic operation: a=" + a + ", b=" + b);

            Console.WriteLine("****************************************************************");

            //overflow
            a = int.MaxValue;
            b = 1;
            Console.WriteLine("Overflow example: " + a + " + " + b + " = " + (a + b));

            //underflow
            a = int.MinValue;
            b = 1;
            Console.WriteLine("Underflow example: " + a + " - " + b + " = " + (a - b));
            /*
                You can easily toggle the Arithmetic Overflow option within the Advanced Build Settings of your Project.
                Right-click your Project within the Solution Explorer.
                Select Properties.
                Select the Build tab along the left.
                Select the Advanced… button (it should be at the very bottom)
                Within the Advanced Build Settings dialog, check the Check for arithmetic overflow.
             */

            //int compilerTest = 2147483648; // will produce compile time error when literal value greater than the max value of an int

            //**********************************************************************************

        }
    }
}
