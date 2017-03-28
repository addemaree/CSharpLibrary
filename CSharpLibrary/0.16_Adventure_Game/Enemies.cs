using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Adventure_Game
{
    class Enemies
    {
                                        //      0       1           2           3           4           5
        protected ArrayList insult = new ArrayList { "buck-o", "wimp", "window licker", "noob", "nerd cakes", "buster" };
        protected Random rnd = new Random();
        public string Name { get; set; }
        public int PowerLevel { get; set; }

        //Constructors

        

        //Methods
        public virtual void Insult ()
        {                                   
            
            //insult.Add("four-eyes");
            
            int r = rnd.Next(insult.Count);

            Console.WriteLine("You're on the wrong side of the forest {0}!", insult[r]);
        }

        public void EnemyPowerLevel()
        {
            Console.WriteLine("{0} is also at {1}", Name, PowerLevel);
        }
    }
}
