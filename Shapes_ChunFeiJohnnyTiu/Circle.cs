using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ChunFeiJohnnyTiu
{
    internal class Circle : IShape
    {
        // Properties
        double radius;
        double area;

        // Constructors

        // Methods
        public double CalculateArea() {
            area = 2 * Math.PI * radius;
            return area;
        }

        public double getArea()
        {
            return area;
        }
    }
}
