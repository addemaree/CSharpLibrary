using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Methods_Netflix_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Netflix rulesofengagement = new Netflix();
            rulesofengagement.Name = "Rules of Engagement";
            rulesofengagement.Genre = "Comedy";
            rulesofengagement.Rating = 4.5;

            Netflix friends = new Netflix();
            friends.Name = "Friends";
            friends.Genre = "Romantic Comedy";
            friends.Rating = 3.8;

            Netflix daredevil = new Netflix();
            daredevil.Name = "DareDevil";
            daredevil.Genre = "Action";
            daredevil.Rating = 4.3;

            rulesofengagement.GetSuggestions();
            friends.GetSuggestions();
            daredevil.GetSuggestions();
            Console.ReadLine();
        }
            
        
    }
}
