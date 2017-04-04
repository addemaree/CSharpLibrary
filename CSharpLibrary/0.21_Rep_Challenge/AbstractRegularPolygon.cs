using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._21_Rep_Challenge
{
    abstract class AbstractRegularPolygon
    {
        //Properties
        public int NumOfSides { get; set; }
        public int SideLength { get; set; }

        //Constructor
        public AbstractRegularPolygon(int sides, int length)
        {
            this.NumOfSides = sides;
            this.SideLength = length;
        }

        //Method
        public double GetPerimeter()
        {
            return NumOfSides * SideLength;
        }

        public abstract double GetArea();
    }
}
