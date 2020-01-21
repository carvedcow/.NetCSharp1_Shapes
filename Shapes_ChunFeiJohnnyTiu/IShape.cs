using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ChunFeiJohnnyTiu
{
    internal interface IShape
    {
        // Methods
        double calculateArea1(double param1);
        double calculateArea2(double param1, double param2);
        string getShapeName();
    }
}
