using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Given Number is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("Given number is Nagative");
            }
            else
            {
                Console.WriteLine("Number is Zero");
            }
        }
    }
}