//20. Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than second number.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsolulteDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(result(13, 40));
            Console.WriteLine(result(50, 21));
            Console.WriteLine(result(0, 23));

            System.Console.ReadLine();
        }

        public static int result(int a, int b)
        {
            if(a > b)
            {
                return (a - b) * 2;
            }
            return b - a;
        }
    }
}
