using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorphism
{
    public class Square : Geometry
    {
        public double SideLength { get; set; }
        public Square()
        {
            SideLength = 5;
        }
        public override double Area()
        {
            return Math.Round(SideLength * SideLength,1);
        }
        public override string ToString()
        {
            return "Fyrkant";
        }
    }
}
