using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliceSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence; 
            string input;
            string search;
            bool found;
            sentence = @"Alice was beginning to get very tired of sitting by her sister on the bank, 
                        and of having nothing to do: once or twice she had peeped into the book her sister 
                        was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' 
                        thought Alice 'without pictures or conversation?'";
            sentence = sentence.ToLower();
            Console.Write("Please enter a string to search for:");
            input = Console.ReadLine();
            search = input.ToLower();
            if (sentence.IndexOf(search) >= 0)
            {
                found = true;
            }
            else
            {
                found = false;
            }
            Console.WriteLine(found);
            Console.ReadLine();
        }
    }
}
