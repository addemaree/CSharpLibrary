using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_Operators_ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            // BASIC OPERATORS TO MEMORIZE NOW - use these 90% of the time

            //+ math and string concatenation
            // = variable assignment
            // ==tests for equality
            // () invokes a method OR can be algebraic order of operations
            // . member acess operator
            // && conditional and 
            // || conditional or


            int number = 10;
            if (number == 7)
                Console.WriteLine("The number is 7");
            else
                Console.WriteLine("The number is not 7");

            //Same as this:
            string response = ((number == 7) ? "hey, The number is 7, yo" : "The number is not 7, yo");
            Console.WriteLine(response);
            Console.ReadLine();
        }
    }
}
