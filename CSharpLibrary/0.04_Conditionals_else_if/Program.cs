using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            //Just goofing around here. Play with a bunch of conditions.
            var bankAccount = 9000;
            var debt = 7000;
            var difference = bankAccount - debt;

            Console.WriteLine("I have $" + bankAccount + " in my bank account, and I am $" + debt + " in debt.");

            if (difference >= 700 && difference <= 1999)
            {
                Console.WriteLine("I have extra money. I should pay off my debt. I'll have $" + difference + " left.");
            }
            else if ((bankAccount - debt >= 2000))
            {
                Console.WriteLine("I have a ton of extra cash right now. I think I could go to Europe!");
            }
            Console.Read();
        }
    }
}
