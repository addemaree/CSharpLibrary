﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Acura tl = new Acura("TL", 2000, 500);
            

            Console.WriteLine(tl.AcuraDetails());
            Console.ReadLine();

        }
    }
}
