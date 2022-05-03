using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Week
{
    internal class ToNumericalSystem
    {

        public static void Num10toOtherBasis()
        {
            long num10;
            Console.Write("Number: ");
            num10 = Int64.Parse(Console.ReadLine());

            int basis;
            Console.Write("Basis: ");
            basis = int.Parse(Console.ReadLine());
            List<char> num_b = new List<char>();
            long priv, rem;
            do
            {
                priv = num10 / basis;
                rem = num10 % basis;
                num_b.Add((char)(rem < 10 ? '0' + rem : 'A' + rem - 10));
                num10 = priv;
            }
            while (num10 > 0);
            Console.Write("The number in new basis is: ");
            num_b.Reverse();
            foreach (char ch in num_b) Console.Write(ch);
            Console.WriteLine();
        }

    }
}
