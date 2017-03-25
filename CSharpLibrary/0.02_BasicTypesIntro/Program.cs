using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypesIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Data Types*****");

            //String Data Type:
            //string = data type, name= type name, value = Adam
            string name = "Adam"; //Declaring and Initializing (Initializing is giving value to the declaration)
           //string = data type, teacher= type name, value = James
            string teacher = "James"; //Just a declaration with no Initialization

            //teacher="Paul"

            /* int //(type) i (declaration) = 0(value);        // implicit conversion, too, a.k.a. Int32
             short sh = 32767; // 2^16, or 32768, or +/- 0-32767, a.k.a. Int16
             byte by = 255;    // 2^8, or 256, or +/- 0-255, a.k.a. Byte
             string s = "hey!"; // up to 2 gigs in size, or 2^32 bytes, or Int32.MaxValue, a.k.a. String
             char c = 'i';  // a string is just a linked list of chars, note the single quotes, a.k.a. Char
             var s2 = @"a \tree";
             var s3 = "a \tree";
             bool b = false; // 1 = true, 0 = false, a.k.a. Boolean
             long l = 7; // long int, 64-bit, a.k.a. Int64
             decimal p; // 128-bit precision decimal, very expensive, a.k.a. Decimal
             double d = 7.80; // 64-bit decimal, a.k.a. Double
             float f = 10.8f; // floating point integer, must put f *explicit* conversion afterwards
                              //if using a constant, or you could cast as (float)
             decimal dd = 7.80m; // must add the m if using a constant, or you could cast as (decimal)
             int? ni = null; // nullable variables, use .HasValue to determine if they are populated, 
             //useful with web services, database results*/

            Console.WriteLine("In class example.");
            Console.WriteLine(name);
            Console.WriteLine(teacher + " " + "is a suave guy " + name + " is learning from him.");

            Console.WriteLine("===================");
            Console.WriteLine("Bronze Challenge");
            
            
            //bronze challenge: list out in seperate sententences who the top 5 coaches are and list them out.

            string coachOne = "Billy Donovan";
            string coachTwo = "Sean Miller";
            string coachThree = "Tony Bennett";
            string coachFour = "Chris Collins";
            string coachFive = "Dane Fife";

            Console.WriteLine(coachOne + " is the number one option for IU.");
            Console.WriteLine(coachTwo + " would be the second best get for the program.");
            Console.WriteLine(coachThree + " would be an interesting pick in my opinion, but has a lot of potential.");
            Console.WriteLine(coachFour + " would be my least favorite pick, but still an interesting option.");
            Console.WriteLine(coachFive + " is my favorite option, but a high risk/high reward pick.");


            //silver challenge: use the same list, but this time use numbers instead of writing them out.
            Console.WriteLine("=============");
            Console.WriteLine("Silver Challenege");
            int numOne = 1;
            int numTwo = 2;
            int numThree = 3;
            int numFour = 4;
            int numFive = 5;

            Console.WriteLine(coachOne + " is the " + numOne + "st option for IU.");
            Console.WriteLine(coachTwo + " would be the " + numTwo + "nd best get for the program.");
            Console.WriteLine(coachThree + " would be the " + numThree + "rd and most interesting pick.");
                     




            Console.ReadLine();
        }
    }
}
