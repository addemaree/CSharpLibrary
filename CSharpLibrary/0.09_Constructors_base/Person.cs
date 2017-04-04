using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_base
{
    class Person
    {
        //Constructor
        public Person(string firstname, string lastname, int age)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Age = age;
        }

        //properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //Method

        public virtual void TestMethod()
        {
            Console.WriteLine("Demo method in Person Class");
        }




    }
}
