using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        public static int SumOf(List<int> numbers)
        {
            int total = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    total += num;
                }
            }
            return total;

        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 2, 26, 9865, 46, 47, 35, 73, 356, 25, 76, 23, 57 ,22, 56, 745, 57 };
            Console.WriteLine("The sum of the even numbers is {0}", SumOf(numbers));
            Console.ReadLine();
        }
    }
}
