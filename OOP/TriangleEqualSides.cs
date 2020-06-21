using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32_210620
{
    class TriangleEqualSides : Triangle
    {
        public override void CalcHekef()
        {
            _hekef = _a + _a + _a;
        }
    }
}
