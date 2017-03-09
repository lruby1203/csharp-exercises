using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan 
                sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus 
                justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum 
                augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            Dictionary<char, int> count = new Dictionary<char, int>();

            string lowerMyString = myString.ToLower();
            foreach (char letter in lowerMyString)
            {
                if (letter >= 'a' && letter <= 'z')
                {
                    if (count.ContainsKey(letter))
                    {
                        count[letter] += 1;
                    }
                    else
                    {
                        count.Add(letter, 1);
                    }
                }
                
            }  
            
            foreach (KeyValuePair<char, int> chars in count)
            {
                string message = string.Format("{0} : {1}", count.Keys, count.Values);
                Console.WriteLine(message);

            }

            Console.ReadLine();
    

        }
    }
}
