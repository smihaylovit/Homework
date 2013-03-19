using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Shapes
{
    abstract class Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        protected Shape(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public abstract double CalculateSurface();
    }
}
