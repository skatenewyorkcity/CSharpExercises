//17. Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.
//Sample Output:
//Input a string : The quick brown fox jumps over the lazy dog.
//TThe quick brown fox jumps over the lazy dog.T

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCharAddedInBeginningAndEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int l = 0;
            Console.Write("Input a string: ");
            str = Console.ReadLine();
            if(str.Length >= 1)
            {
                var s = str.Substring(0, 1);
                Console.WriteLine(s + str + s);
            }

            System.Console.ReadLine();
        }
    }
}
