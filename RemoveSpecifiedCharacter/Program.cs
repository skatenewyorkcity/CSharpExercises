//15. Write a C# program remove specified a character from a non-empty string using index of a character. Go to the editor
//Test Data:
//w3resource
//Sample Output:
//wresource
//w3resourc
//3resource

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveSpecifiedCharacter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(remove_char("w3resource", 1));
            Console.WriteLine(remove_char("w3resource", 9));
            Console.WriteLine(remove_char("w3resource", 0));

            System.Console.ReadLine();
        }

        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
}
