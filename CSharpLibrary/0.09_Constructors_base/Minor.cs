using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_base
{
    class Minor: Person
    {
        //Constructor
        public Minor(string firstname, string lastname, int age, bool isInSchool) : base(firstname, lastname, age)
        {
            this.IsInSchool = isInSchool;
        }

        //Properties
        public bool IsInSchool { get; set; }

        //Methods
        public override void TestMethod()
        {
            Console.WriteLine("Test method in Minor Class");
        }

        public void DemoMethod()
        {
            Console.WriteLine("Demo method in Minor class");
        }

    }
}
