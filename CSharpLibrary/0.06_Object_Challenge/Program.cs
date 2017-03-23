using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Object_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Hotel Motel5 = new Hotel();
             Motel5.RoomNumber = 504;
             Motel5.Availability = true;
             Motel5.NumberofBeds = 2;
             Console.WriteLine(Motel5.Availability);
             Console.WriteLine("Mr. Jones, your room number is " + Motel5.RoomNumber);
             Console.WriteLine("The room will have " + Motel5.NumberofBeds + " beds. Please Enjoy your stay!");

             Console.ReadLine();*/



            //Silver Challenge

            Hotel QualityInn = new Hotel();
            QualityInn.FirstName = "Christopher";
            QualityInn.LastName = "Demaree";
            QualityInn.RoomNumber = 603;

            QualityInn.PrintRoomNumber();
            Console.ReadLine();
            
        }
    }
}
