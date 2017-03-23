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
        public int TotalMinutes { get; set; }


        //Methods
        /// <summary>
        /// Methods with no return.
        /// </summary>

        public void GetSuggestions()
        {
            if (this.Rating >= 4)
                Console.WriteLine("You've gotta see this show!");
            else
                Console.WriteLine("Don't waste your life with this thing.");
        }

        /// <summary>
        /// Methods that return a value.
        /// </summary>
       


        public string PayBill()
        {
            return "You just paid your bill";
        }
          
        public int ShowRuntime()
        {
            Console.WriteLine(this.Name + " is " + this.TotalMinutes + " minutes");
            return this.TotalMinutes;
        }

        ///Methods that have parameters

        public string ShowWhoViewed(string username, string time)
        {
            string details = username + " watched this at " + time;
            return details;
        }

        public int ShowNumberOfMinutesLeft(int minutesViewed)
        {
            int numMinutesLeft = this.TotalMinutes - minutesViewed;
            Console.WriteLine("There are " + numMinutesLeft + " minutes left in " + this.TotalMinutes + " minutes of the show, so there are " + numMinutesLeft + " minutes left.");
            return numMinutesLeft;
        }
    }
}
