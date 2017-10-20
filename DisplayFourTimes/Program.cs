//12. Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}.
//Test Data:
//Enter a digit: 25 
//Expected Output:
//25 25 25 25 
//25252525 
//25 25 25 25 
//25252525

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayFourTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter a digit: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Part A: "num num num num" using Write
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.WriteLine();

            //Part B: "numnumnumnum" using write
            Console.Write(num);
            Console.Write(num);
            Console.Write(num);
            Console.WriteLine(num);
            Console.WriteLine();

            //Part C: "num num num num" using {0}
            Console.WriteLine("{0} {0} {0} {0}", num);

            //Part D: "numnumnumnum" using {0}
            Console.WriteLine("{0}{0}{0}{0}", num);

            System.Console.ReadLine();
        }
    }
}
