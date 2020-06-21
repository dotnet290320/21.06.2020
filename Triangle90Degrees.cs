using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32_210620
{
    class Triangle90Degrees : Triangle
    {
        public override void CalcArea()
        {
            double result = (_a * _b) / 2.0;
            _area = result;
        }

    }
}
