using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Student devan = new Student();
            devan.FirstName = "Devan";
            devan.LastName = "Peetz";
            devan.Age = 25;

            Student charlesMichael = new Student("Charles", "Michael", 30, "Assassin");
            Student adamDemaree = new Student("Adam", "Demaree", 26, "Beginner");
            Console.ReadLine();
           



        }
    }
}
