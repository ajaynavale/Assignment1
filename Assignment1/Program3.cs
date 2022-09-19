using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program3
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter the Character");
            char ch = char.Parse(Console.ReadLine());

            if(ch=='a' || ch == 'e' || ch == 'i' || ch== 'o' || ch== 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Character is Vowel");
            }
            else
            {
                Console.WriteLine("Character is Consonant");
            }
        }
    }
}
