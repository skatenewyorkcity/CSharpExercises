//28. Write a C# program to reverse the words of a sentence.
//Sample Output:
//Original String: Display the pattern like pyramid using the alphabet.
//Reverse String: alphabet.the using pyramid like pattern the Display

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWordsInSentence
{
    class Program
    {
        static void Main(string[] args)
        {

            string line = "Display the pattern like pyramid using the alphabet.";
            Console.WriteLine("\nOriginal String: " + line);
            string result = "";
            List<string> wordsList = new List<string>();

            string[] words = line.Split(new[]
            {
                " "
            }, StringSplitOptions.None);
            for(int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }

            wordsList.Add(result);
            foreach(String s in wordsList)
            {
                Console.WriteLine("\nReverse String: " + s);
            }

            System.Console.ReadLine();
        }
    }
}
