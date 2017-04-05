using System;

namespace _0._01_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //to initialize a command in the console log use:

            //Console.WriteLine("Hello World");       


            ////Bronze Challenge: write a sentence saying who the top five choices are for IU

            //Console.WriteLine("The top five coaches are: ");
            //Console.WriteLine("1. Billy Donovan 2. Sean Miller 3. Tony Bennett 4. Chris Collins 5. Dane Fife");


            //Gold Badge Assessment

            //1.

            int x;
            bool isInSchool;
            string fullName;
            double y;
            decimal z;

            //2.

            x = 26;
            fullName = "Adam Demaree";
            

            Console.WriteLine("{0} is {1} years old, and lives in Indianapolis.", fullName, x);

            //3.

            string[] friends = new string[] { "Lauren Winters", "Brad Lohsl", "Anthony Lower", "Michael Goldberg", "Josh Meyer" };

            foreach (string friend in friends)
                {
                Console.WriteLine(friends);
            }
            






            Console.ReadLine();
        }
    }
}
