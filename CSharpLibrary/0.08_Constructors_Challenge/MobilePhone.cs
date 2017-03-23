using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Constructors_Challenge
{
    class MobilePhone
    {

        //Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public string Owner { get; set; }

        //Constructors
        public MobilePhone(string make, string model, string owner)
        {
            this.Make = make;
            this.Model = model;
            this.Owner = owner;
        }

        //Methods

        public void PrintToScreen()
        {
            Console.WriteLine(Owner + " owns an " + Make + " " + Model);
        }
            
           
    
            
        


    }
}
