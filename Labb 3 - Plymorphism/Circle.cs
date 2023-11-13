using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorphism
{
    public class Circle : Geometry
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 4;
        }

        public override double Area()
        {
            return Math.Round(Radius * Radius * Math.PI,1);
        }
        public override string ToString()
        {
            return "Cirkel";
        }
    }
}
