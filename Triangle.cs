using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32_210620
{
    class Triangle : Shape
    {
        public double _a, _b, _c, _h;

        public override void CalcArea()
        {
            double result = (_c * _h) / 2.0;
            _area = result;
        }

        public override void CalcHekef()
        {
            _hekef = _a + _b + _c;
        }
    }
}
