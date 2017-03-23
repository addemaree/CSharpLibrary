using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Methods_Netflix_Challenge
{
    class Netflix
    {
        

        //Properties
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }


        //Methods
        public void GetSuggestions()
        {
            if (this.Rating >= 4)
                Console.WriteLine("You've gotta see this show!");
            else
                Console.WriteLine("Don't waste your life with this thing.");
        }




        public string PayBill()
        {
            return "You just paid your bill";
        }
          
    }
}
