//14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
//Test Data:
//Enter the amount of celsius: 30
//Expected Output:
//Kelvin = 303
//Fahrenheit = 86

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelciusToKelvinAndFarenheitConverter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the amount of celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Farenheit = {0}", celsius * 18 / 10 + 32);

            System.Console.ReadLine();

        }
    }
}
