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


            }
        }
    }
}
