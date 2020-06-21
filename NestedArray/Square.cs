using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedArray
{
    class Square : Shape
    {
        public double _a;

        public override void PrintAreaFormula()
        {
            Console.WriteLine($"a^2");
        }
    }
}
