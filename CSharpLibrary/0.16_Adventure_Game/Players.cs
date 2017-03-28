using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Adventure_Game
{
    public enum CharacterType
    {
        Assassin = 0,
        BlitzenBlopper = 1,
        Professor = 2,
        HorseMange = 3,
        TaxMan = 4,
        Human = 5
    }
    class Players
    {

        //Properties of Class
        public string PlayerName { get; set; }
        public string Clan { get; set; }
        public string Weapon { get; set; }
        public int CurrentPower { get; set; }
        public CharacterType Type { get; set; }

        //Class Constructor
        public Players(string name, string clanName, string weapon, CharacterType type = CharacterType.HorseMange)
        {
            this.PlayerName = name;
            this.Clan = clanName;
            this.Weapon = weapon;
            this.CurrentPower = 100;
            this.Type = type;
        }
        //Method
        public CharacterType ChooseType(int t)
        {
            switch(t)
            {
                case 0:
                    Console.WriteLine("You are an Assassin");
                    return this.Type = CharacterType.Assassin;
                case 1:
                    Console.WriteLine("You are a Blitzen Blopper");
                    return this.Type = CharacterType.BlitzenBlopper;
                case 2:
                    Console.WriteLine("You are a Professor");
                    return this.Type = CharacterType.Professor;
                case 3:
                    Console.WriteLine("You are a Horse Mange");
                    return this.Type = CharacterType.HorseMange;
                case 4:
                    Console.WriteLine("You are a Tax Man");
                    return this.Type = CharacterType.TaxMan;
                case 5:
                    Console.WriteLine("You are a Human");
                    return this.Type = CharacterType.Human;
                default:
                    Console.WriteLine("You are a Horse Mange");
                    return this.Type = CharacterType.HorseMange;
            }
        }
        public override string ToString()
        {
            return $"Player Name: {this.PlayerName}\nGamer Name: {this.Clan}\nPlayer Type: {this.Type}";
        }
        public void PowerLevelCheck()
        {
            Console.WriteLine("Hello {0} your power level is full at {1}", PlayerName, CurrentPower);
        }

        public void BattleCry()
        {
            Console.WriteLine("{0} screams out 'I shall end you!'", PlayerName);
        }

        public void WeaponOfChoice()
        {
            Console.WriteLine("I shall use my weapon of choice.. the {0}!", Weapon);
        }







    }

}
