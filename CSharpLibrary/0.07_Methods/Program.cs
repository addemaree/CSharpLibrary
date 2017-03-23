using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer theJSWizard = new Customer();
            theJSWizard.FirstName = "James";
            theJSWizard.LastName = "Handshoe";
            theJSWizard.Email = "";
            theJSWizard.AppearsWealthy = false;

            theJSWizard.PrintCustomerName();

            Customer AdamDemaree = new Customer();
            AdamDemaree.FirstName = "John";
            AdamDemaree.LastName = "Doe";

            AdamDemaree.PrintCustomerName();

            Console.ReadLine();

        }
    }
}
