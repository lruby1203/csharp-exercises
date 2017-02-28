using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            float length;
            float width;
            float area;
            string input;
            Console.WriteLine("Please enter the length of the rectangle:");
            input = Console.ReadLine();
            length = float.Parse(input);
            Console.WriteLine("Please enter the width of the rectangle:");
            input = Console.ReadLine();
            width = float.Parse(input);
            area = length * width;
            Console.WriteLine("The area of the rectangle is " + area);
            Console.ReadLine();

            



        }
    }
}
