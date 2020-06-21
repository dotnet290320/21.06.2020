using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32_210620
{
    abstract class Shape
    {
        public double _area;
        public double _hekef;

        public void PrintTheArea()
        {
            Console.WriteLine($"Area = {_area}");
        }

        // 1 every derived class must have the CalcArea function
        // 2 I cannot implement this function, because its a shape specific function
        public abstract void CalcArea(); // only signature

        // 1 every derived class must have the CalcHekef function
        // 2 I cannot implement this function, because its a shape specific function
        public abstract void CalcHekef(); // only signature
    }
}
