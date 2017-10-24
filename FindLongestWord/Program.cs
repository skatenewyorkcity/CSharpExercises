//24. Write a C# program to find the longest word in a string. 
//Test Data: Write a C# Sharp Program to display the following pattern using the alphabet.
//Sample Output:
//following

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach(String s in words)
            {
                if(s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine(word);

            System.Console.ReadLine();
        }
    }
}
