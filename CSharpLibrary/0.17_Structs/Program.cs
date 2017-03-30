using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookEntry Paul = new AddressBookEntry("Paul", "O'Connor", 45)
            {
                Address = "123 Coder pl",
                City = "Westfield",
                State = "IN",
                Zip = "44056",
                FirstName = "Paul",
                LastName = "O'Connor",
                Age = 45

            };

            AddressBookEntry Adam = new AddressBookEntry("Adam", "Demaree", 26)
            {
                Address = "600 N Alabama St. Apt. 1203",
                City = "Indianapolis",
                State = "IN",
                Zip = "46204",
                FirstName = "Adam",
                LastName = "Demaree",
                Age = 26
            };

            AddressBookEntry Lauren = new AddressBookEntry("Lauren", "Winters", 26)
            {
                Address = "1010 N Central Ave. Apt. 313",
                City = "Indianapolis",
                State = "IN",
                Zip = "46202",
                FirstName = "Lauren",
                LastName = "Winters",
                Age = 26
            };

            AddressBookEntry Dad = new AddressBookEntry("Trip", "Demaree", 57)
            {
                Address = "7845 E Gelding Dr. Suite 103",
                City = "Scottsdale",
                State = "AZ",
                Zip = "85260",
                FirstName = "Trip",
                LastName = "Demaree",
                Age = 57
            };

            Console.WriteLine(Paul.GetAddress());
            Console.ReadLine();
        }


    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Program (string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }
    struct AddressBookEntry
    {     
        
        public string FirstName;
        public string LastName;
        public int Age;
        public string Address;
        public string City;
        public string State;
        public string Zip;

        public string GetAddress()
        {
            return $"Address: {Address}\nCity:{City}\nState:{State}\nZip: {Zip}";
        }
    }
}

