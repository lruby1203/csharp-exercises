using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasMileage
{
    class Program
    {
        static void Main(string[] args)
        {
            float miles;
            float gallons;
            float mileage;
            string input;
            Console.WriteLine("Please enter the number of miles driven:");
            input = Console.ReadLine();
            miles = float.Parse(input);
            Console.WriteLine("Please enter the gallons of gas used:");
            input = Console.ReadLine();
            gallons = float.Parse(input);
            mileage = miles/gallons;
            Console.WriteLine("Your gas milage is " + mileage + " miles per gallon");
            Console.ReadLine();
        }
    }
}
