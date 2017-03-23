using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling today from 1-5?");
            string feelingNumber = Console.ReadLine();

            if (feelingNumber == "5")
            {
                Console.WriteLine("Wow! That's great to hear.");
            }
            else if (feelingNumber == "4")
            {
                Console.WriteLine("Well that's cool. How can we make it better?");
            }
            else if (feelingNumber == "3")
            {
                Console.WriteLine("Well that's cool. How can we make it better?");
            }
            else
            {
                Console.WriteLine("Boo. What can I do to help?");
            }
            Console.ReadLine();
        }
    }
}
