//27. Write a C# program and compute the sum of the digits of an integer.
//Input a number(integer): 12
//Sum of the digits of the said integer: 3 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigitsOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number(integer): ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while(n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine("Sum of the digits of the said integer: " + sum);

            System.Console.ReadLine();
        }
    }
}
