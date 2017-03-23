using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Collections_ArraysOfObject
{
    class Country
    {
        //Constructors
        public Country(string name, string capital)
        {
            this.Name = name;
            this.Captial = capital;

        }
        //Properties
        public string Name { get; set; }
        public string Captial { get; set; }
        //Method
        public void PrintCountryDetails()
        {
            Console.WriteLine("The Capital of " + Name + " is " + Captial);
        }

  

    }
}
