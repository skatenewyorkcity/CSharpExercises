//25. Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
//Sample Output:
//Odd numbers from 1 to 99. Prints one number per line.
//1 
//3 
//5 
//7 
//9 
//...
//95
//97 
//99

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintOddOneToHundred
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Odd numbers from 1 to 99. Prints one per line.");
            for(int n = 1; n < (99 + 1); n++)
            {
                if(n % 2 != 0)
                {
                    Console.WriteLine(n.ToString());
                }
            }

            System.Console.ReadLine();
        }
    }
}
