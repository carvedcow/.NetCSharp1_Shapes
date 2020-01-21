using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ChunFeiJohnnyTiu
{
    class Canvas
    {
        // Properties
        public double radius { get; set; }
        public double length { get; set; }
        public double width { get; set; }
        public double area { get; set; }

        // Constructors

        // Methods
        public void CalculateArea(IShape shape) {
            area = shape.CalculateArea();
        }



    


    }
}
