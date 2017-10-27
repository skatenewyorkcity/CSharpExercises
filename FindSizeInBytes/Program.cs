//29. Write a C# program to find the size of a specified file in bytes.
//Sample Output:
//Size of a file: 31 

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSizeInBytes
{
    class Program
    {
        static void Main(string[] args)
        {

            FileInfo f = new FileInfo("/home/students/abc.txt");
            Console.WriteLine("\nSize of file: " + f.Length.ToString());

            System.Console.ReadLine();

        }

    }
}
