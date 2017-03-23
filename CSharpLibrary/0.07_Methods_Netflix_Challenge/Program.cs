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
            rulesofengagement.TotalMinutes = 22;
            rulesofengagement.GetSuggestions();
            rulesofengagement.ShowRuntime();
            Console.WriteLine(rulesofengagement.ShowWhoViewed("Ava", "10"));
            rulesofengagement.ShowNumberOfMinutesLeft(5);


            Netflix friends = new Netflix();
            friends.Name = "Friends";
            friends.Genre = "Romantic Comedy";
            friends.Rating = 3.8;
            friends.TotalMinutes = 24;
            friends.GetSuggestions();
            friends.ShowRuntime();
            Console.WriteLine(friends.ShowWhoViewed("Adam and Lauren", "11"));
            friends.ShowNumberOfMinutesLeft(12);



            Netflix daredevil = new Netflix();
            daredevil.Name = "DareDevil";
            daredevil.Genre = "Action";
            daredevil.Rating = 4.3;
            daredevil.GetSuggestions();



            Console.ReadLine();
        }
            
        
    }
}
