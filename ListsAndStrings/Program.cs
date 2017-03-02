using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndStrings
{
    class Program
    {
        public static void Those(List<string> words)
        {
            foreach (string word in words)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                }
            }
        }
        static void Main(string[] args)
        {
            List<string> words = new List<string> { "gold", "catch", "cat", "string", "toddler", "potty" };
            Console.WriteLine("The words with 5 characters are:");
            Those(words);
            Console.ReadLine();
        }
    }
}

