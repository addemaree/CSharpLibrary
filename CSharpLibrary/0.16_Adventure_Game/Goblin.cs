using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Adventure_Game
{
    class Goblin : Enemies
    {
        //properties

        public string EnemyNameOne { get; set; }
        public string EnemyTypeOne { get; set; }
        public string AttackMoveOne { get; set; }

        //constructors

        public Goblin()
        {
            this.PowerLevel = 40;
            this.Name = "Goblin";
        }

        //Methods

        public override void Insult()
        {
            int r = rnd.Next(insult.Count);
            Console.WriteLine("I am {0} at a full health of {1}pts you {2}!", this.Name, this.PowerLevel, insult[r]);
        }
        
    }
}
        



    

