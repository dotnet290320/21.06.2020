using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32_210620
{
    class Circle : Shape
    {
        // public double ;
        public double _radius;

        public override void CalcArea()
        {
            double result = Math.PI * _radius * _radius;
            _area = result;
        }

        public override void CalcHekef()
        {
            double result = 2 * Math.PI * _radius;
            _hekef = result;
        }
    }
}
