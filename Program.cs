using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32_210620
{
    
    class Program
    {
        static void CalcAreaAndPrintCircle(Circle c)
        {
            c.CalcArea();
            Console.WriteLine($"The area is {c._area}");
        }

        static void CalcAreaAndPrintTriangle(Triangle t)
        {
            t.CalcArea();
            Console.WriteLine($"The area is {t._area}");
        }

        static void CalcAreaAndPrintShape(Shape s)
        {
            s.CalcArea();
            Console.WriteLine($"The area is {s._area}");
        }

        static void Main(string[] args)
        {
            //Shape shape = new Shape();
            Circle circle = new Circle()
            {
                _radius = 8.5
            };

            //circle.CalcArea();

            CalcAreaAndPrintCircle(circle);

            Triangle triangle = new Triangle()
            {
                _a = 1.0,
                _b = 3.4,
                _c = 2.8,
                _h = 3.0
            };
            triangle.CalcArea();

            Triangle90Degrees triangle90Degrees = new Triangle90Degrees()
            {
                _a = 11.0,
                _b = 33.4,
                _c = 21.8,
                _h = 33.0
            };

            triangle90Degrees.CalcArea();


            CalcAreaAndPrintShape(circle);
            CalcAreaAndPrintShape(triangle);

        }
    }
}
