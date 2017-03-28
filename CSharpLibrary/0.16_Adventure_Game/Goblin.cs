using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Adventure_Game
{
    class Goblin : Enemies
    {
        Dictionary<string, int> Attacks = new Dictionary<string, int> {
                { "Head-Butt", 5 },
                { "Mallet", 15 },
                { "Poison Fangs", 35 }
            };


        //properties

        public string EnemyNameOne { get; set; }
        public string EnemyTypeOne { get; set; }
        public string AttackMoveOne { get; set; }

        //constructors

        public Goblin()
        {
            this.PowerLevel = 40;
            this.Name = "Azark the Goblin";
        }

        //Methods

        public override void Insult()
        {
            int r = rnd.Next(insult.Count);
            Console.WriteLine("I am {0} at a full health of {1}pts you {2}!", this.Name, this.PowerLevel, insult[r]);
        }
        
        public void GoblinAttack(Players player)
        {
            Attack(player, Attacks, this.Name);
        }
    }
}
        



    

