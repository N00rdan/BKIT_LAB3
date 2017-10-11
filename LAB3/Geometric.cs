using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    abstract class Geometric : IComparable
    {
        public abstract double Square
        {
            get;
        }

        public int CompareTo(object obj)
        {
            Geometric o = (Geometric)obj;
            if (this.Square > o.Square)
                return 1;
            else if (this.Square < o.Square)
                return -1;
            else return 0;
        }
    }
}
