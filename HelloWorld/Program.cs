using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
            Console.ReadLine();

        }
    }
}
