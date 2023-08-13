using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine("Sum of elements: " + sum);
            Console.ReadLine();
        }
    }
}
