using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._21_Rep_Challenge
{
    class Triangle : AbstractRegularPolygon
    {
        //Constructor
        public Triangle(int length) : base(3,length) { }

        public override double GetArea()
        {
            return SideLength * SideLength * Math.Sqrt(3) / 4;
        }
    }
}
