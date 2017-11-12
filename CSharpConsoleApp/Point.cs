using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleApp2
{
    public struct Point // class 와 struct 차이가 있다.
    {
        public int x;
        public int X { get { return x; } set { x = value; } } //read write 둘 다 가능하게 하겠다.
        public int y;
        public int Y { get { return y; } set { y = value; } } //자동 property

        public Point(int _x = 0, int _y = 0)
        {
            x = _x;
            y = _y;
        }
        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpConsoleApp2
//{
//    public class Point
//    {
//        public int X { get; set; } //read write 둘 다 가능하게 하겠다.
//        public int Y { get; set; } //자동 property

//        public Point()
//        {
//            X = 0;
//            Y = 0;
//        }
//        public Point(int _x = 0, int _y = 0)
//        {
//            X = _x;
//            Y = _y;
//        }
//        public override string ToString()
//        {
//            return "(" + X + "," + Y + ")";
//        }
//    }
//}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace CSharpConsoleApp2
//{
//    public class Point
//    {
//        private int x, y;

//        public Point() { }
//        public Point(int _x = 0, int _y = 0)
//        {
//            x = _x;
//            y = _y;
//        }
//        public override string ToString()
//        {
//            return "(" + X + "," + Y + ")";
//        }
//        public int X
//        {
//            get { return x; }
//            set { x = value; }
//        }
//        public int Y
//        {
//            get { return y; }
//            set { y = value; }
//        }
//    }
//}