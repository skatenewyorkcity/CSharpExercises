﻿//6. Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
//Test Data:
//Input the first number to multiply: 2
//Input the second number to multiply: 3
//Input the third number to multiply: 6
//Expected Output:
//2 x 3 x 6 = 36

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, num3;

            Console.Write("Input the first number to multiply: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the first second to multiply: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the first third to multiply: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int result = num1 * num2 * num3;
            Console.WriteLine("Output: {0} x {1} x {2} = {3}",
                num1, num2, num3, result);

            System.Console.ReadLine();
        }
    }
}
