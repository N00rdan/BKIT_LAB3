using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class Circle : Geometric, PrintInterface
    {
        public double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if(value <0)
                    throw new Exception("Radius must be non-negative");
                radius = value;
            }
        }

        public Circle(double a)
        {
            if (a < 0)
                throw new Exception("Width must be non-negative");
            radius = a;
        }

        public override double Square
        {
            get
            {
                return Math.PI * radius * radius;
            }
        }

        public override string ToString()
        { 
            return "Circle:: Radius: " + radius + "; Square: " + Square;
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
