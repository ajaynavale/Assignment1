using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.WriteLine("Year is leap");
            }
            else
            {
                Console.WriteLine("Year is not Leap");
            }
        }
    }
}
