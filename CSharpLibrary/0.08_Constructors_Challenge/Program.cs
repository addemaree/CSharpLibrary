using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Constructors_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            MobilePhone friendOne = new MobilePhone("Apple", "iPhone 7", "Adam");
            MobilePhone friendTwo = new MobilePhone("Apple", "iPhone 5s", "Lauren");




            friendOne.PrintToScreen();
            friendTwo.PrintToScreen();
            Console.ReadLine();
        }
    }
}
