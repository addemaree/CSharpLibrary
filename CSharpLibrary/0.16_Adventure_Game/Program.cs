using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Adventure_Game
{
    class Program
    {
        static void Main(string[] args)
        {

           // BlitzenBlopper = 1,
        //Professor = 2,
        //HorseMange = 3,
        //TaxMan = 4,
        //Human = 5

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What clan are you apart of?");
            string clan = Console.ReadLine();
            Console.WriteLine("What is your weapon of choice?");
            string weapon = Console.ReadLine();
            Console.WriteLine("What is your player type?\n" +
                "0: Assassin\n" +
                "1: Blitzen Blopper\n" +
                "2: Professor\n" +
                "3: Horse Mange\n" +
                "4: Tax Man\n" +
                "5: Human");
            int playerType = int.Parse(Console.ReadLine());

            Players player = new Players(name, clan, weapon);
            player.ChooseType(playerType);

            Console.WriteLine(player.ToString());



            //Enemies Quagga = new Enemies("Bill");
            //Quagga.Name = "Bill";
            //Console.WriteLine("The enemy Quagga named {0} responds:", Quagga.Name);

            //Quagga.enemyInsult();
            //Quagga.enemyPowerLevel();


            Goblin Goblin = new Goblin();

            Goblin.Insult();



            Console.ReadLine();
        }
    }
}
