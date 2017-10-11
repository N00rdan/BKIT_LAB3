using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class Rectangle : Geometric
    {
        private double width, height;
        public Rectangle()
        {
            width = 0;
            height = 0;
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Width must be non-negative");

                width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value < 0)
                    throw new Exception("Height must be non-negative");
                height = value;
            }
        }

        public override double Square
        {
            get
            {
                return width * height;
            }
        }

        public override string ToString()
        {
            return "Rectangle:: Width: " + Width + "; Height: " + height + "; Square: " + Square;
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
