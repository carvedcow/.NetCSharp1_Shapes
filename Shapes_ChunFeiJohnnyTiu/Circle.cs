﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ChunFeiJohnnyTiu
{
    internal class Circle : IShape
    {


        // Methods
        public double calculateArea1(double param1) {
            return (2 * Math.PI * param1);
        }

        public double calculateArea2(double param1, double param2) {
            return 0;
        }

        public string getShapeName() {
            return "Circle";
        }
    }
}
