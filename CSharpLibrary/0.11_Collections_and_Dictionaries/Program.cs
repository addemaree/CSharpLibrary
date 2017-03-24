using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Collections_and_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Cat", "annoying creature.");
            dictionary.Add("Dog", "man's best friend.");

            foreach(KeyValuePair<string, string> pair in dictionary)
            {
                Console.WriteLine("{0} is a {1}", pair.Key, pair.Value);
            }

            Console.WriteLine("================");
            //Bronze:**/

            Dictionary<string, string> bestPicture = new Dictionary<string, string>();
            bestPicture.Add("2000", "Gladiator");
            bestPicture.Add("2001", "A Beautiful Mind");
            bestPicture.Add("2002", "Chicago");
            bestPicture.Add("2003", "Lord of the Rings: Return of the King");
            bestPicture.Add("2004", "Million Dollar Baby");
            bestPicture.Add("2005", "Crash");

            foreach(KeyValuePair<string, string> pair in bestPicture)
            {
                Console.WriteLine("In {0}, {1} won the pivitol Best Picture award.", pair.Key, pair.Value);
            }

            //Silver:

            Dictionary<string, string[]> bestPictureNoms = new Dictionary<string, string[]>();
            bestPictureNoms.Add("2000", new string[] { "Gladiator", "Chocolat", "CTHD" });
            bestPictureNoms.Add("2001", new string[] { "Beautiful Mind", "Gosford Park", "In the Bedroom" });
            bestPictureNoms.Add("2002", new string[] { "Chicago", "The Lord of the Rings: Two Towers", "Gangs of New York" });

            foreach (KeyValuePair<string, string[]> bestPictureNom in bestPictureNoms)
            {
                Console.WriteLine("In {0}: {1}, {2}, {3}", bestPictureNom.Key, bestPictureNom.Value[0], bestPictureNom.Value[1], bestPictureNom.Value [2]);
            }


            //gold:

            Console.WriteLine(bestPicture["2002"]);
            Console.WriteLine("Please type a year to show the movie that won:");
            string input1 = Console.ReadLine();

            if (bestPicture.ContainsKey(input1))
            {
                string valueForKey = bestPicture[input1];
                Console.WriteLine("The best picture in " + input1 + " was " + valueForKey);
            }

            Console.WriteLine("Please type a year to show the movies that were up for an award that year: ");
            string input2 = Console.ReadLine();

            if (bestPictureNoms.ContainsKey(input2))
            {
                string[] valueforkey = bestPictureNoms[input2];
                string nomineeString = string.Join("", "", valueforkey);
                Console.WriteLine("The best nominees in " + input2 + " were " + nomineeString);
            }

            
            
            
            
            
            
            //weekend challenge: bronze
            //creat a dictionary with an array for the year (200-2005) with and array of national player of the year nominees





            //weekend challenge: silver
            //create same as bronze but for big ten player of the year nominees 

            //weekend challenge: gold
            //create same as silver but for 2006-2010 and do it without looking at previous examples


            Console.ReadLine();

        }
    }
}
