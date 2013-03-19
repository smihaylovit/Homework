using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Shapes
{
    
        class Circle : Shape
        {

            public Circle(double radius)
                : base(radius, radius) { }

            public override double CalculateSurface()
            {
                return Math.PI * this.Height * this.Width;
            }

        }

}
