using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Shapes
{
    class Triangle : Shape
    {
        public Triangle(double height, double width)
            : base(height, width) { }

        public override double CalculateSurface()
        {
            return (this.Height * this.Width) / 2; //using brackets for good reading
        }
    }
}
