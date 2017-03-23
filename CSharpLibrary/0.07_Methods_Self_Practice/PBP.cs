using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Methods_Self_Practice
{
    class PBP
    {
        public string playerName { get; set; }


        public void scoringPlays()
        {
            Console.WriteLine(playerName + " scored 2 points by driving to the basket.");
        }

        public void scoringPlays(int numberOfPoints)
        {
            Console.WriteLine(playerName + " scored " + numberOfPoints + "by driving to the basket.");
        }

    }
}
