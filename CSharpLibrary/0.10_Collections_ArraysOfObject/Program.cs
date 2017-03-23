using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Collections_ArraysOfObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Country[] countries = new Country[10];
            countries[0] = new Country("Honduras", "Tegucigalpa");
            countries[1] = new Country("Italy", "Rome");
            countries[2] = new Country("Brazil", "Rio De Janero");
            countries[3] = new Country("Austrailia", "Sydney");
            countries[4] = new Country("Nicaragua", "Managua");
            countries[5] = new Country("USA", "Washington D.C.");
            countries[6] = new Country("Peru", "Lima");
            countries[7] = new Country("Japan", "Tokyo");
            countries[8] = new Country("China", "Beijing");
            countries[9] = new Country("France", "Paris");

            foreach (var country in countries)
            {
                country.PrintCountryDetails();
            }

            Console.ReadLine();

        }
    }
}
