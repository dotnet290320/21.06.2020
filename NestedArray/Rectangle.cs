using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedArray
{
    class Rectangle : Shape
    {
        public double _height, _width;

        public override void PrintAreaFormula()
        {
            Console.WriteLine($"height * width");
        }
    }
}
