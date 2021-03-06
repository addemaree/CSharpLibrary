﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Adventure_Game
{
    abstract class Enemies //further protects enemy class
    {
                                        //      0       1           2           3           4           5
        protected ArrayList insult = new ArrayList { "buck-o", "wimp", "window licker", "noob", "nerd cakes", "buster" };
        protected Random rnd = new Random();
        public string Name { get; set; }
        public int PowerLevel { get; set; }

        //Constructors

        public Enemies()
        {
            this.PowerLevel = 40;
        }

        //Methods
        public virtual void Insult ()
        {                                   
            
            //insult.Add("four-eyes");
            
            int r = rnd.Next(insult.Count);

            Console.WriteLine("You're on the wrong side of the forest {0}!", insult[r]);
        }

        public void EnemyPowerLevel()
        {
            Console.WriteLine("{0} is also at full health at {1}", Name, PowerLevel);
        }
        //setting a target for the enemy
        public void Attack(Players player, Dictionary<string, int> dict, Object enemyName)
        {
            
           
            var singleAttack = dict.ElementAt(rnd.Next(dict.Count));
            int attackVal = singleAttack.Value;
            string attackName = singleAttack.Key;

            Console.WriteLine("Enemy is attacking with {0} and deals {1}HP", attackName, attackVal);
            
            Console.WriteLine("{0}'s power level was at {1}HP", player.PlayerName, player.CurrentPower);
            player.CurrentPower -= attackVal; //player.CurrentPower = player.CurrentPower -15


        }
    }
}
