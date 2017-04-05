using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._22_Knowledge_Check
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine("====================");

            //3.

            string[] friends = new string[] { "Lauren", "Brad", "Michael", "Anthony", "Josh" };

            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }

            Console.WriteLine("===============");

            //Part Two:

            //NOTE: 4-9 in seperate subclasses

            //10. 

            Customer adam = new Customer("Adam", "iPhone 7", GenderType.Male);

            adam.ThankYou();
            adam.SendSalesNotice();
            Console.WriteLine("===============");

            InactiveCustomer lauren = new InactiveCustomer("Lauren", "iPhone SE", GenderType.Female, 10, ReasonsForInactivity.Broke);

            lauren.SendSalesNotice();

            lauren.InactiveNotice();

            Console.WriteLine("===============");
            lauren.PrintCustomerInfo();




            Console.ReadLine();







        }
    }
}
