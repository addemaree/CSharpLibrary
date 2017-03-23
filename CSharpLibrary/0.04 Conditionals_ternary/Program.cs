using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ternary Example


            int favoriteNumber = 22;
            //if (favoriteNumber == 25)
            //Console.WriteLine("That is my favorite number. Good guess!");
            //else
            //Console.WriteLine("Eh good guess, but no dice!");


            string response = (favoriteNumber == 25 ? "That is my favorite number. Good guess!" : "Eh good guess, but no dice!");
            Console.WriteLine(response);
            Console.ReadLine();

            //Challenge: Using a string of name check to see if your name is the same as your 
            //neighbors, return a message if not return another message.

        }
        
    }
}
