using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._22_Knowledge_Check
{
    //4.

    public enum GenderType
    {
        Male = 0,
        Female = 1,
        Undefined = 2
    }
    class Customer
    {
      

        //Constructor
        //5. 

        public Customer(string customerName, string purchase, GenderType type= GenderType.Undefined)
        {
            this.CustomerName = customerName;
            this.Purchase = purchase;
            this.Type = type;
        }

        //Properties
        public string CustomerName { get; set; }
        public string Purchase { get; set; }
        public GenderType Type { get; set; }


        //Method
       
      //6.

        public void ThankYou ()
        {
            Console.WriteLine("Hey {0}! We wanted to send a special thank you for purchasing your new {1} today. We hope you enjoy it!", CustomerName, Purchase);
        }

        //7.

        public virtual void SendSalesNotice()
        {
            Console.WriteLine("Hello {0}! We wanted to let you know there's a sale coming up on 4/1/2017!", CustomerName);
        }

        //11.
        public virtual void PrintCustomerInfo ()
        {
            Console.WriteLine("{0} \n {1} \n {2}", CustomerName, Purchase, Type);
        }

        


    }
}
