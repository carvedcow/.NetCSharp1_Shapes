using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ChunFeiJohnnyTiu
{
    internal class Rectangle : IShape
    {
        // Properties
        double length;
        double width;
        double area;

        // Constructors

        // Methods
        public double CalculateArea()
        {
            area = length * width;
            return area;
        }

        public double getArea()
        {
            return area;
        }
    }
}
