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
        Dictionary<string, int> Fighting = new Dictionary<string, int> {
                { "Punch", 5 },
                { "Kick", 10 },
                { "Slash", 15 },
                { "Stab", 20 }
            };
        protected Random rnd = new Random();
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
            switch (t)
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
            return "Player Name: {this.PlayerName}\nGamer Name: {this.Clan}\nWeapon of Choice: {this.Weapon}\nPlayer Type: {this.Type}";
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
       
        
        
        
        //Setting a target for Player
        public void PlayerAttack(Goblin Azark, Dictionary<string, int> dict, Object enemyName)
        {
            var singleAttack = dict.ElementAt(rnd.Next(dict.Count));
            int attackVal = singleAttack.Value;
            string attackName = singleAttack.Key;

            Console.WriteLine("{0} is attacking {1} with {2}, which deals {3}HP", this.PlayerName, Azark.Name, attackName, attackVal);

            Console.WriteLine("{0}'s power was at {1}HP", Azark.Name, Azark.PowerLevel);
            Azark.PowerLevel -= attackVal; //player.CurrentPower = player.CurrentPower -15
                   
        }

        public void PlayerAttack(Goblin azark)
        {
            PlayerAttack(azark, Fighting, this.PlayerName);
        }
    }
}
