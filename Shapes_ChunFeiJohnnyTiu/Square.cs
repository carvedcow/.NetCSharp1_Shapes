using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ChunFeiJohnnyTiu
{
    internal class Square : IShape
    {
        // Properties
        double length;
        double area;

        // Constructors

        // Methods
        public double CalculateArea()
        {
            area = length*length;
            return area;
        }

        public double getArea()
        {
            return area;
        }
    }
}
