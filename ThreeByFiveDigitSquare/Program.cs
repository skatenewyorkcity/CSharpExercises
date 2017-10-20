//13. Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.
//Test Data:
//Enter a number: 5 
//Expected Output:
//555 
//5 5
//5 5 
//5 5 
//555

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeByFiveDigitSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("Enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0}{0}{0}", x);

            System.Console.ReadLine();
        }
    }
}
