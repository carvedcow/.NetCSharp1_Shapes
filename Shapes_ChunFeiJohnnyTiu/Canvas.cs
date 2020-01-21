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
        public void CalculateArea(IShape shape) 
        {
            switch (shape.getShapeName())
            {
                case "Circle":
                    area = shape.calculateArea1(radius);
                    break;
                case "Square":
                    area = shape.calculateArea1(length);
                    break;
                case "Rectangle":
                    area = shape.calculateArea2(length, width);
                    break;
            }
        }



    


    }
}
