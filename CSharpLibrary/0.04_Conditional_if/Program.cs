using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditional_if
{
    class Program
    {
        static void Main(string[] args)
        {
            /*bool isOn = true;
            bool isHot = false;

            if (isOn)
            {
                Console.WriteLine("The light is on. It's bright.");
            }
            Console.ReadLine();*/


            //Challenge: Create an isAdmin bool. Write an if statement that says
            //if a user is an admin, then "Welcome to the site Admin


            //bool isAdmin = true;
            //bool isGuest = false;

            //if (isAdmin)
            //{
            //    Console.WriteLine("Welcome to the site Admin");
            //}
            //Console.ReadLine();

            //Next Challenge: Using a comparison operator for "and" using the isAdmin, and a new bool for 
            //isLoggedIn create an If statement that prints out "You are logged in! and you are an Admin."

            bool isAdmin = true;
            bool isLoggedIn = true;

            if (isAdmin && isLoggedIn)
            {
                Console.WriteLine("You are logged in! and you are an Admin.");
            }
            Console.ReadLine();

         
            
            
            /*
            //2
            if (isOn == true)
            {
                Console.WriteLine("The light is on");
            }

            if (isOn && isHot)
            {
                Console.WriteLine("Lights on and it's hot");
            }

            if (isOn || isHot)
            {
                Console.WriteLine("lights on or it is hot");
            }

            if (!isHot)
            {
                Console.WriteLine("it is not hot");
            }*/
            
        }
    }
}
