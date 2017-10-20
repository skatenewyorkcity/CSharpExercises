﻿//4.Write a C# Sharp program to print the result of the specified operations.
//Test data:

//-1 + 4 * 6
//(35 + 5) % 7
//14 + -4 * 6 / 11
//2 + 15 / 6 * 1 - 7 % 2
//Expected Output:
//23
//5
//12
//3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecifiedOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine(-1 + 4 * 6);
            //-1 + 24 = 23
            System.Console.WriteLine((35 + 5) % 7);
            //40 % 7 = 5 (remainder of 40/7)
            System.Console.WriteLine(14 + -4 * 6 / 11);
            //14 - (24/11) = 14 - 2 = 12
            System.Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            //2 + (15/6) - remainder of (7/2) = 2+ 2 - 1 = 4 - 1 = 3


            System.Console.ReadLine();
        }
    }
}
