﻿//10. Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.
//Test Data:
//Enter first number - 5
//Enter second number - 6
//Enter third number - 7

//Expected Output:
//Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputXYZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3;

            Console.Write("Enter first number - ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number - ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number - ");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Result of specified numbers {0}, {1} and {2}, (x+y).z is {3} and x.y + y.z is {4}\n\n",
                number1, number2, number3, ((number1 + number2) * number3), (number1 * number2 + number2 * number3));

            System.Console.ReadLine();
        }
    }
}
