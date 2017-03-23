using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Methods_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player theJSWizard = new Player();
            theJSWizard.Attack("JS Wizard");
            theJSWizard.Attack("JS Wizard", "Dusty Wand");
            theJSWizard.Attack("JS Wizard", "Dusty Wand", 2);
            Console.ReadLine();
        }
    }
}
