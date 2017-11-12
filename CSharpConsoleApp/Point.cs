using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleApp2
{
    public class Point
    {
        private int x, y;

        public Point() { }
        public Point(int _x = 0, int _y = 0)
        {
            x = _x;
            y = _y;
        }
        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
