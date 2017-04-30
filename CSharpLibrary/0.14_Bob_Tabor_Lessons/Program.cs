using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Bob_Tabor_Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Variables= "Buckets that we can drop memory in"
             int x;
             int y;

             //int= c sharp term that refers to a number with no fraction or decimal numbers 
             //(smallest form of bucket memory when dealing with numbers)

             //Values="Memory that is put in that bucket"
             x = 7;
             y = x + 3;
             Console.WriteLine(y);*/


            //variables can be named whatever you want. We use camelcasing in variable naming which is lowercase 
            //for the first part of the name and then normal capital lettering for the second part.

            /*string myfirstname;
            myfirstname = "Adam";



            Console.WriteLine(myfirstname);*/

            /*int x = 7;
            string y = "5";
            string myFirstTry = x + y;
            int mySecondTry = x + int.Parse(y);
            Console.WriteLine(myFirstTry);
            Console.WriteLine(mySecondTry);*/

            //Console.WriteLine("Please type something and press Enter");
            //string userValue;
            //userValue = Console.ReadLine();
            //Console.WriteLine("You typed: " + userValue);

            Console.WriteLine("Which coach would you like to coach Indiana? Archie Miller, Dane Fife, Billy Donovan, or Tom Crean?");
            string coachValue = Console.ReadLine();

            if (coachValue == "Archie Miller")
            {
                Console.WriteLine("You chose correctly!");
                Console.ReadLine();
            }
            else if (coachValue == "Dane Fife")
            {
                Console.WriteLine("Psh I wish!");
                Console.ReadLine();
            }
            else if (coachValue == "Billy Donovan")
            {
                Console.WriteLine("In your dreams!");
                Console.ReadLine();
            }
            else if (coachValue == "Tom Crean")
            {
                Console.WriteLine("Quit living in the past!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No one cares about him..");
                Console.ReadLine();
            }

            //Console.WriteLine(message);
            //Console.ReadLine();

            //This is the same thing as:

            Console.WriteLine("Which coach would you like to coach Indiana? Archie Miller, Dane Fife, Billy Donovan, or Tom Crean?");
            string coachChoice = Console.ReadLine();

            string message;

            if (coachValue == "Archie Miller")
            {
                message = "You chose correctly!";
            }
            else if (coachValue == "Dane Fife")
            {
                message = "Psh I wish!";

            }
            else if (coachValue == "Billy Donovan")
            {
                message = "In your dreams!";

            }
            else if (coachValue == "Tom Crean")
            {
                message = "Quit living in the past!";

            }
            else
            {
                message = "No one cares about him..";

            }

            Console.WriteLine(message);
            Console.ReadLine();


            //Console.WriteLine("Which of these choices do you conside your best friend? Kayley, Maddie, Katy, Rachel, Adam");
            //string bestFriend = Console.ReadLine();

            //string message;

            //if (bestFriend == "Kayley")
            //    message = "I thought that is what you would say";
            //else if (bestFriend == "Maddie")
            //    message = "Nope. Try again...";
            //else if (bestFriend == "Katy")
            //    message = "I could see why you would say that, but not what I was thinking..";
            //else if (bestFriend == "Rachel")
            //    message = "Close, but no cigar..";
            //else if (bestFriend == "Adam")
            //    message = "Quit brown nosin me and guess again ;)";
            //else
            //    message = "Never would have thought you would say that..";

            //Console.WriteLine(message);


            //Same thing also as this:

            //Console.WriteLine("Which of these choices do you conside your best friend? Kayley or Maddie");
            //string bestFriend = Console.ReadLine();

            //string message = (bestFriend == "Kayley") ? "I thought that is what you would say" : "Guess again";
            //Console.WriteLine("Hey!" +
            //    " {0}! You typed: {1}", message, bestFriend);












            //Console.WriteLine("Who is going to be the next coach at Indiana? Archie Miller or Billy Donovan?");
            //string nextCoach = Console.ReadLine();

            //string message = (nextCoach == "Archie Miller") ? "You are spot on!" : "that would be cool but guess again..";

            //Console.WriteLine("Hey! {0} You typed: {1}", message, nextCoach);





            //Console.WriteLine("Who of these players is going to stay? Robert Johnson, JBJ, TB, OG?");
            //string playerStaying = Console.ReadLine();

            //string message;
            //string message = (playerStaying == "Robert Johnson" ? "That is what I think too." : "I wouldn't bet on it.");
            //Console.WriteLine("Hmm. {0} Because you said: {1}", message, playerStaying);

            //if (playerStaying == "Robert Johnson")
            //    message = "That is what I think too";
            //else if (playerStaying == "JBJ")
            //    message = "I hope that is not the case!";
            //else if (playerStaying == "TB")
            //    message = "He should come back, but I doubt it.";
            //else if (playerStaying == "OG")
            //    message = "This is my number one choice, but I don't think it will happen";
            //else
            //    message = "No one is talking about him.";

            //Console.WriteLine(message);

            Console.ReadLine();















































        }
    }
}
