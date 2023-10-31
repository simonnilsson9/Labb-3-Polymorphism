using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Plymorphism
{
    public class Rectangle : Geometry
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle()
        {
            Length = 10;
            Width = 5;
        }       
        public override double Area()
        {            
            return Length*Width;            
        }
        public override string ToString()
        {
            return "Rektangel";
        }
    }
}
