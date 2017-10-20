//19. Write a C# program to compute the sum of two given integers, 
//if two values are equal then return the triple of their sum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoIntsReturnTripleTheSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumTriple(2,2));
            Console.WriteLine(SumTriple(12, 10));
            Console.WriteLine(SumTriple(-5, 2));

            System.Console.ReadLine();
        }

        public static int SumTriple(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;
        }
    }
}
