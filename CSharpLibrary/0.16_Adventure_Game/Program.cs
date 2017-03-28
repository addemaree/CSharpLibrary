using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Adventure_Game
{
    class Program
    {
        static void Main(string[] args)
        {


            //SpeechSynthesizer talkingConsole = new SpeechSynthesizer();
            //talkingConsole.Speak("What is your name?");

            //This code is asking the console, or player to enter in their information before finally spitting it back out.
            //It uses the constructor in the player class for each string. In order for the console to give an opportunity for the player to respond,
            //you have to write the declaration and variable (in this case string) and set it equal to "console.readline();"

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What clan are you apart of?");           
            string clan = Console.ReadLine();
            Console.WriteLine("What is your weapon of choice?");            
            string weapon = Console.ReadLine();
            // "\n = line break" This references what player type you will be.
            Console.WriteLine("What is your player type?\n" +
                "0: Assassin\n" +
                "1: Blitzen Blopper\n" +
                "2: Professor\n" +
                "3: Horse Mange\n" +
                "4: Tax Man\n" +
                "5: Human");            
            // "int. parse" allows the console to read the strings, or player types, and converts them into the number typed in by the user
            int playerType = int.Parse(Console.ReadLine());

            //This line of code is adding a new player to the class.
            Players player = new Players(name, clan, weapon);

            //This line of code is letting the console know which type of player you are. If you comment or delete this line, then the type will not show up as
            //the name of the player, but rather the number that the player type is associated with 
            player.ChooseType(playerType);

            //This line of code tells the console to write out what the user typed when answering the intial questions
            //It gives the system the ability to spit out the player details
            //The "To.String();" method needs to be inside of a Console.WriteLine(); !!
            Console.WriteLine(player.ToString());

            Console.WriteLine("==================");
            Console.WriteLine("First Level Enemy");



            Goblin Azark = new Goblin();

            while(true)
            {
                Console.WriteLine("Do you want to fight? yes or no?");
                string userAnswer = Console.ReadLine();
                if (userAnswer == "yes")
                {
                    Azark.GoblinAttack(player);
                    if(player.CurrentPower <=0)
                    {
                        Console.WriteLine("Oh you dead!");
                        Azark.Insult();
                        break;
                    }

                }
                else
                {
                    break;
                }
                
            }

            
            //Console.WriteLine(player.CurrentPower);
            //Azark.GoblinAttack(player);
            //Console.WriteLine(player.CurrentPower);
            //Console.WriteLine("This is a new attack");
            //Azark.GoblinAttack(player);
            //Console.WriteLine(player.CurrentPower);
            

            //Azark.GoblinAttack(player);



            Console.ReadLine();
        }
    }
}
