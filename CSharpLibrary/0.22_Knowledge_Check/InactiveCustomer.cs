using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._22_Knowledge_Check
{
    //12.
    public enum ReasonsForInactivity
    {
        SwitchedService = 0,
        Moved = 1,
        PrefersDifferentCompany = 2,
        Broke = 3

    }
    class InactiveCustomer : Customer
    {
        

        //7. 

        //Constructor
        //8.
        public InactiveCustomer(string customerName, string purchase, GenderType type, int monthsInactive, ReasonsForInactivity reasons) : base(customerName, purchase, type)
        {
            this.MonthsInactive = monthsInactive;
            this.Reasons = reasons;
        }

        //Property
        private int MonthsInactive { get; set; }
        public ReasonsForInactivity Reasons { get; set; }


        //Method
        //7.
        public override void SendSalesNotice()
        {
            Console.WriteLine("Hey {0}, we wanted to let you know there is a sale on our {1}'s coming up on 4/1/2017!", CustomerName, Purchase);
        }


        public void InactiveNotice ()
        {
            if (MonthsInactive > 4)
            {
                Console.WriteLine("Thanks for shopping with us {0}. We saw that your last purchase of an {1} was {2} months ago, and we would like to see if any of our deals would interest you.", CustomerName, Purchase, MonthsInactive);
            }
            else
            {
                Console.WriteLine("Thanks {0} for continuing to be a consistent valued customer!", CustomerName);
            }
        }

        public override void PrintCustomerInfo()
        {
            Console.WriteLine(" Name: {0}\n Product Purchased: {1}\n Gender: {2}\n Months Inactive: {3}\n Reason: {4}", CustomerName, Purchase, Type, MonthsInactive, Reasons);
        }





    }
}
