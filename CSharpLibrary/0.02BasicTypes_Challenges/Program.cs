using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02BasicTypes_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Declaration Bronze Challenge

            int age = 26;
            int oldage;

            string first = "Adam is ";
            string second = " years old, but last year was ";

            bool isMarried;
            bool isHappy = true;

            float amountofSnow;
            float temperature = 67.9f;

            double latitude;
            double oneThird = 3.333333d;

            decimal =
            decimal =*/


            Silver Challenge

            string firstName;
            string lastName;
            string Birthday;
            string age;

            firstName = "Adam";
            lastName = "Demaree";
            Birthday = "May 25 1990.";
            age = "26";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            Console.WriteLine(fullName + " was born on " + Birthday);
            Console.WriteLine(fullName + " is " + age + " years old.");

            Console.ReadLine();

            //Gold Challenge

            string firstName;
            string lastName;
            string presidentNumber;
            string electionDate;

            firstName = "Donald";
            lastName = "Trump";
            presidentNumber = "45th president";
            electionDate = "November 8 2016.";
            Console.WriteLine(firstName + " " + lastName + " won the election on " + electionDate);
            Console.WriteLine("This makes " + firstName + " " + lastName + " the " + presidentNumber + " of the United States.");
            Console.ReadLine();

















           
        }
    }
}
