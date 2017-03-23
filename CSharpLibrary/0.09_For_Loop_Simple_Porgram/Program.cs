using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_For_Loop_Simple_Porgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your starting Number: ");
            int startingNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your ending Number: ");
            int endingNum = Int32.Parse(Console.ReadLine());


            //Can you use startingNum and endingNum to create a for loop that will add every number in between

            int sum = 0;
            for(int i = startingNum; i <= endingNum; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum of {0} and {1} is {2}", startingNum, endingNum, sum);

            Console.ReadLine();
        }
    }
}
