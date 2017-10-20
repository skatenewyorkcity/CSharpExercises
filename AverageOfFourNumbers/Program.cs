//9. Write a C# Sharp program that takes four numbers as input to calculate and print the average.
//Test Data:
//Enter the First number: 10 
//Enter the Second number: 15 
//Enter the third number: 20 
//Enter the four number: 30 

//Expected Output:
//The average of 10 , 15 , 20 , 30 is: 18

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfFourNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1, number2, number3, number4;

            Console.Write("Enter the First number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Third number: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the four number: ");
            number4 = Convert.ToInt32(Console.ReadLine());

            int result = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
                number1, number2, number3, number4, result);

            System.Console.ReadLine();

        }
    }
}
