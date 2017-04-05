using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_For_Each_Lopps
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;
                                        //0   1   2   3   4  5
            int[] lottoNums = new int[] { 15, 4, 16, 23, 42, 7 };
            string[] names = new string[] { "James", "Paul", "Obi Wan", "Annakin", "Meow", };
            Console.WriteLine(numbers[0]);
            Console.WriteLine(lottoNums[5]);

            Console.WriteLine("================");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("===========");

            foreach (int number in lottoNums)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("=============");

            //write a for loop to console.writeline each name

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("====================");
            string[] friends = new string[] { "Lauren", "Brad", "Michael", "Anthony", "Josh" };

            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }
            Console.ReadLine();
        }
    }
}
