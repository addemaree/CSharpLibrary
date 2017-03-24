using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear barryTheBear = new Bear();
            barryTheBear.HasEyes = true;
            barryTheBear.Hibernate = true;
            barryTheBear.Meal = "Humans";
            barryTheBear.NumberOfLegs = 4;
            barryTheBear.Weight = 2000;

            Console.WriteLine("Bear Methods");
            barryTheBear.Walks();
            barryTheBear.Speak();


            Console.WriteLine("==============");

            Console.WriteLine("Dog Methods");

            Dog spotTheDog = new Dog();
            spotTheDog.NumberOfPaws = 4;
            spotTheDog.Gender = "Male";
            spotTheDog.Bark = false;

            
            spotTheDog.Runs();          
            spotTheDog.Protect();

            Console.WriteLine("=========");

            Console.WriteLine("Polar Bear Methods");







            Console.ReadLine();
        }
    }
}
