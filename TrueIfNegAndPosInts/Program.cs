//18. Write a C# program to check two given integers and return true if one is negative and one is positive.
//Sample Output:
//Input first integer:
//-5 
//Input second integer: 
//25 
//Check if one is negative and one is positive: 
//True 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueIfNegAndPosInts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInput first integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check if one is negative and one is positive: ");
            Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));

            System.Console.ReadLine();
        }
    }
}
