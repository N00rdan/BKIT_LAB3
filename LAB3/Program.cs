using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Square s = new Square(16);
            Circle c = new Circle(6);

            ArrayList al = new ArrayList() { r, s, c };

            al.Sort();
            foreach (var x in al) Console.WriteLine(x);


            Console.ReadLine();
        }
    }
}
