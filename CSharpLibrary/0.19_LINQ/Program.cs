using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._19_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UsedCar> usedCars = new List<UsedCar>
            {
                new UsedCar() {VIN = "A1", Make = "Honda", Model = "Accord Coupe", Price = 6000, Year = 2008},
                new UsedCar() {VIN = "B1", Make = "Honda", Model = "Crosstour", Price = 12000, Year = 2011},
                new UsedCar() {VIN = "C12", Make = "Accura", Model = "TL-X", Price = 4000, Year = 2007},
                new UsedCar() {VIN = "D31", Make = "Jeep", Model = "Wrangler", Price = 9000, Year = 2012},
                new UsedCar() {VIN = "B11", Make = "BMW", Model = "Cheyenne", Price = 6500, Year = 2008},
                new UsedCar() {VIN = "A14", Make = "Nissan", Model = "Accura", Price = 3000, Year = 2005}
            };




            //var hondas = from car in usedCars
            //           where car.Make == "Honda"
            //           select car;
            //foreach(var honda in hondas)
            //{
            //    Console.WriteLine("The {0} {1} is nice used car options that we offer.", honda.Make, honda.Model);
            //}

            //string carShopping;
            //Console.WriteLine("Hey shopper...What type of price range are we looking for?");
            //carShopping = Console.ReadLine();
            var cars = from car in usedCars
                       where car.Price > 5000
                       select car;
            foreach (var car in cars)
            {
                Console.WriteLine("The {0} {1} is a great option at a cheap price of {2:C}",
                    car.Make,
                    car.Model,
                    car.Price);
            }

            //Console.WriteLine("");
            //Console.WriteLine("LINQ with Lambda");
            //var BMWs = usedCars.Where(car => car.Make == "BMW");
            //foreach(var bmw in bmws)
            //{
            //    Console.WriteLine(bmw.Model);
            //}

            //var niceUsedCars = usedCars.Where(car => car.Price > 7500 && car.Make == "Honda" || car.Make == "Jeep");
            //foreach (var niceUsedCar in niceUsedCars)
            //{
            //    Console.WriteLine(niceUsedCar.Model + " " + niceUsedCar.VIN);
            //}

            Console.ReadLine();
        }
    }

    class UsedCar
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
    }
}
