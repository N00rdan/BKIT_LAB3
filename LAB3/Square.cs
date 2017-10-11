using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class Square : Rectangle, PrintInterface
    {
        public Square(double a) : base()
        {
            if (a < 0)
                throw new Exception("Width must be non-negative");
            Width = a;
            Height = Width;
        }
        public override string ToString()
        {
            return "Sqare:: Width: " + Width + "; Square: " + Square;
        }

        public new void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
