using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Object_Challenge
{
    class Hotel
    {
        public int RoomNumber { get; set; }
        public bool Availability { get; set; }
        public int NumberofBeds { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintRoomNumber()
        {
            Console.WriteLine("Hello {0} {1}, your room number is {2}.", FirstName, LastName, RoomNumber);
        }
    }


    
}
