using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._22_Knowledge_Check
{
    class Customer
    {
       //4.
       
            public enum GenderType
        {
            Male = 0,
            Female = 1,
            Undefined = 2
        }

        //Constructor
        //5. 

        public Customer(string customerName, string purchase, GenderType type)
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
       
       public GenderType Choosetype (int t)
        {
            switch (t)
            {
                case 0:
                    Console.WriteLine("Male");
                    return this.Type = GenderType.Male;
                case 1:
                    Console.WriteLine("Female");
                    return this.Type = GenderType.Female;
                case 2:
                    Console.WriteLine("Undefined");
                    return this.Type = GenderType.Undefined;
                default:
                    Console.WriteLine("Undefined");
                    return this.Type = GenderType.Undefined;

            }
        }

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
