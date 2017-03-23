using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend = Console.ReadLine();

            switch (friend)
            {
                case "Goldberg":
                    Console.WriteLine("Hey Goldberg, let's go golfing");
                    break;
                case "Lohsl":
                    Console.WriteLine("Let's grab a beer!");
                    break;
                case "Lower":
                    Console.WriteLine("Ready to do a podcast?");
                    break;
                case "Fred":
                    Console.WriteLine("Hey man I am busy right now. Sorry!");
                    break;
                default:
                    Console.WriteLine("Hey " + friend + " can I call you back in a minute?");
                    break;
            }
            Console.ReadLine();
        }
    }
}
