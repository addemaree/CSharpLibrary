using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Donuts appleCinn = new Donuts();
            appleCinn.Filling = "apple pie";
            appleCinn.IsSpecial = false;
            appleCinn.Price = 0.99M;
            appleCinn.Type = "Filled";
            Console.WriteLine(appleCinn.Price);

            Donuts longJohn = new Donuts();
            longJohn.Filling = "Bavarian Creme";
            longJohn.IsSpecial = true;
            longJohn.Price = 1.25M;
            longJohn.Type = "Filled";
            Console.WriteLine("A LongJohn cost about {0:C}", longJohn.Price);
            Console.ReadLine();
        }
        
       
    }
}
