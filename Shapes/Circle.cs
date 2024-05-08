using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius=radius;
        }

        public double Radius {get;set;}
        public override double GetArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }

        public override double GetPerimetr()
        {
            return Math.Round(Math.PI * 2 * Radius);
        }
    }
}
