using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : Shape
    {
        public Rectangle(double a, double b) 
        {
            Width = a;
            Height = b;
        }
        public double Width {get;set;}
        public double Height { get;set;}
        public override double GetArea()
        {
            return Math.Round(Height * Width,2);
        }

        public override double GetPerimetr()
        {
            return Math.Round(2*(Height+Width), 2);
        }
    }
}
