﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ChunFeiJohnnyTiu
{
    class GUI
    {
        // Default Message
        public void AppStart()
        {
            Console.WriteLine("Area Calculator\n Select your shape and parameters");
        }

        // Get Shape
        public IShape getShape()
        {
            IShape selectedShape = new Circle();//initialize the IShape
            Console.WriteLine("Select your shape: (1 = circle, 2 = rectangle, 3 = square)");
            int selected = Int32.Parse(Console.ReadLine());
            switch (selected) {
                case 1:
                    selectedShape = new Circle();
                    break;
                case 2:
                    selectedShape = new Rectangle();
                    break;
                case 3:
                    selectedShape = new Square();
                    break;
            }
            return selectedShape;
        }

        // Get Parameter
        public double getParameter(string param) 
        {
            Console.Write($"Enter your {param}: ");
            double enteredParam = double.Parse(Console.ReadLine());
            return enteredParam;
        }
    }
}
