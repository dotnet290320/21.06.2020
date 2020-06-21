using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };
            int[] numers2 = new int[5];
            numers2[0] = 1;
            numers2[1] = 2;
            numers2[2] = 3;
            numers2[3] = 4;
            numers2[4] = 5;

            Rectangle[] rectangles = new Rectangle[2];
            rectangles[0] = new Rectangle()
            {
                _height = 5.4,
                _width = 7.6
            };
            rectangles[1] = new Rectangle()
            {
                _height = 9.2,
                _width = 0.15
            };

            rectangles[0].PrintAreaFormula();

            Square[] squares = new Square[2];
            squares[0] = new Square()
            {
                _a = 8
            };
            squares[1] = new Square()
            {
                _a = 9
            };
            squares[1].PrintAreaFormula();

            Shape[] shapes = new Shape[2];
            shapes[0] = new Rectangle()
            {
                _height = 9,
                _width = 10
            };
            shapes[1] = new Square()
            {
                _a = 19
            };
            shapes[0].PrintAreaFormula();
            shapes[1].PrintAreaFormula();

            Console.WriteLine("========================");

            MyCanvas myCanvas = new MyCanvas()
            {
                _totalHeight = 1800,
                _totalWidth = 900,
                _shapes = new Shape[2]
                {
                    new Rectangle()
                    {
                        _height = 4,
                        _width = 2
                    },
                    new Square()
                    {
                        _a = 12
                    }
                }
            };
        }
    }
}
