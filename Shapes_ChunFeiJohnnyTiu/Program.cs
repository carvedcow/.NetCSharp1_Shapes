using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ChunFeiJohnnyTiu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Properties
            bool toContinue = true;
            GUI display = new GUI();
            Canvas canvas = new Canvas();

            while (toContinue) {
                // Clear Console
                Console.Clear();

                // Start App
                display.AppStart();

                // Get Shape
                IShape shape = display.getShape();

                // Depending on shape, Get Param
                switch (shape.getShapeName()) {
                    case "Circle":
                        canvas.radius = display.getParameter("circle's radius");
                        break;
                    case "Square":
                        canvas.length = display.getParameter("square's length");
                        break;
                    case "Rectangle":
                        canvas.length = display.getParameter("rectangle's length");
                        canvas.width = display.getParameter("rectangle's width");
                        break;
                }

                // Get Area from Canvas
                canvas.CalculateArea(shape);

                // Print Area
                Console.WriteLine($"Your area is {canvas.area}.");

                // Continue?
                Console.Write("Continue: (Y/N)? ");
                var contKey = Console.ReadKey();
                toContinue = (contKey.Key == ConsoleKey.Y ? true : false);
            }
        }
    }
}
