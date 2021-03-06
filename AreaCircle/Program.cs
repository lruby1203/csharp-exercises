﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double area;
            string input;
            do
            {
                Console.Write("Please enter the radius of the circle: ");
                input = Console.ReadLine();
            }
            while ((input.Length == 0) || (input.All(char.IsDigit) == false) || (double.Parse(input) < 0));
            

            radius = double.Parse(input);
            area = Math.PI * radius * radius;
            Console.WriteLine("The area of a circle with a radius of {0} is {1:0.###}", radius, area);
            Console.ReadLine();
        }
    }
}
