using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Methods_Overloading
{
    class Player
    {
        //Attack X 3

        public void Attack(string playerName)
        {
            Console.WriteLine("The player " + playerName + " attacked for 5 points");
        }
        public void Attack( string playerName, string weapon)
        {
            Console.WriteLine("The player " + playerName + " attacked with the rusty " + weapon);

        }
        public void Attack(string playerName, string weapon, int attackPoints)
        {
            Console.WriteLine("The player " + playerName + " attacked with the rusty " + weapon + " for " + attackPoints + " points.");
        }

    }
}
