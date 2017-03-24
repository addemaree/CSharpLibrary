using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Inheritance
{
    class Dog : Animal
    {
        public bool Bark { get; set; }
        public int NumberOfPaws { get; set; }
        public string Gender { get; set; }
        public int NumberofPaws { get; internal set; }

        public void Runs()
        {
            Console.WriteLine("I just ran a lap around the yard. Watch me do it again!");
        }

        public void Protect()
        {
            Console.WriteLine("BARK BARK (Stranger Danger!)");
        }


    }
}
