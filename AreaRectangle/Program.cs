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
            double length;
            double width;
            Console.Write("Please enter the length of the rectangle:");
            length = double.Parse(Console.ReadLine());
            Console.Write("Please enter the width of the rectangle:");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("The area of the rectangle is " + length * width);
            Console.Read();

            



        }
    }
}
