//5. Write a C# Sharp program to swap two numbers. 
//Test Data:
//Input the First Number : 5
//Input the Second Number : 6
//Expected Output: 
//After Swapping :
//First Number : 6 
//Second Number : 5 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, temp;
            Console.Write("\nInput the First Number: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number: ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("\nAfterSwapping: ");
            Console.Write("\nFirst Number: " +number1);
            Console.Write("\nSecond Number: " +number2);
            Console.Read();

            System.Console.Read();
        }
    }
}
