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

            int x = 7;
            string y = "5";
            string myFirstTry = x + y;
            int mySecondTry = x + int.Parse(y);
            Console.WriteLine(myFirstTry);
            Console.WriteLine(mySecondTry);



            Console.ReadLine();







        }
    }
}
