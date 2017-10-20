//8. Write a C# Sharp program that takes a number as input and print its multiplication table.
//Test Data:
//Enter the number: 5
//Expected Output:
//5 * 0 = 0
//5 * 1 = 5
//5 * 2 = 10 
//5 * 3 = 15
//....
//5 * 10 = 50


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int result;

            Console.WriteLine("Enter a number:");
            x = Convert.ToInt32(Console.ReadLine());

            result = x * 1;
            Console.WriteLine("The table is : {0} x {1} = {2}", x, 1, result);
            result = x * 2;
            Console.WriteLine("The table is : {0} x {1} = {2}", x, 2, result);
            result = x * 3;
            Console.WriteLine("The table is : {0} x {1} = {2}", x, 3, result);
            result = x * 4;
            Console.WriteLine("The table is : {0} x {1} = {2}", x, 4, result);
            result = x * 5;
            Console.WriteLine("The table is : {0} x {1} = {2}", x, 5, result);
            result = x * 6;
            Console.WriteLine("The table is : {0} x {1} = {2}", x, 6, result);
            result = x * 7;
            Console.WriteLine("The table is : {0} x {1} = {2}", x, 7, result);
            result = x * 8;
            Console.WriteLine("The table is : {0} x {1} = {2}", x, 8, result);
            result = x * 9;
            Console.WriteLine("The table is : {0} x {1} = {2}", x, 9, result);
            result = x * 10;
            Console.WriteLine("The table is : {0} x {1} = {2}", x, 10, result);

            System.Console.ReadLine();
        }
    }
}
