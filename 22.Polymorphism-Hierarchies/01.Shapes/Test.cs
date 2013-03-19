using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Shapes
{
    class Test
    {
        public static void Shape()
        {
            Shape[] myShapes = new Shape[] {
                
                new Circle(3),
                new Rectangle(2,3),
                new Triangle(2,3)

            };

            foreach (Shape item in myShapes)
            {
                Console.WriteLine("Shape {0} has surface: {1}", item.GetType(), item.CalculateSurface());
            }
        }
    }
}
