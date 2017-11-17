// Array
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpConsoleApp
{
    class Program
    {
        static void PrintArray(int[] arr)
        {
            for(int i =0; i < arr.Length; ++i)
            {
                Console.WriteLine("{0,4}", arr[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            PrintArray(arr);
        }
    }
}



//// Anonymous
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var pt1 = new { X = 2, Y = 3 }; //새로운 형식이 만들어진다.
//            Console.WriteLine(pt1);
//            Console.WriteLine(pt1.GetType().Name);
//            Console.WriteLine("{0}, {1}", pt1.X, pt1.Y);

//            Console.WriteLine();

//            var pt2 = pt1;
//            Console.WriteLine(pt2);
//            Console.WriteLine(pt2.GetType().Name);
//            Console.WriteLine("{0}, {1}", pt2.X, pt2.Y);
//        }
//    }
//}


//// Anonymous
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace CSharpConsoleApp
//{
//    class Point
//    {
//        public int X { get; set; }
//        public int Y { get; set; }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Point pt1 = new Point() { X = 2, Y = 3 };
//            Console.WriteLine(pt1);
//            Console.WriteLine(pt1.GetType().Name);
//            Console.WriteLine("{0}, {1}", pt1.X, pt1.Y);
//        }
//    }
//}


//// Anonymous
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace CSharpConsoleApp
//{
//    class Point { }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var d = new { Int = 100, Name = "data", Pt = new Point() };

//            Console.WriteLine(d);
//            Console.WriteLine(d.GetType().Name);
//            Console.WriteLine("{0}, {1}, {2}", d.Int, d.Name, d.Pt);
//        }
//    }
//}


//// Anonymous
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace CSharpConsoleApp
//{
//    class Point { }
//    class Data
//    {
//        public int Int { get; set; }
//        public string Name { get; set; }
//        public Point Pt { get; set; }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Data d = new Data(){ Int = 100, Name = "data", Pt = new Point() };

//            Console.WriteLine(d);
//            Console.WriteLine("{0}, {1}, {2}", d.Int, d.Name, d.Pt);
//        }
//    }
//}



//// down, up casting
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        class Point
//        {
//            int x, y;
//            public Point(int _x = 0, int _y = 0)
//            {
//                x = _x;
//                y = _y;
//            }
//            public override string ToString()
//            {
//                return "(" + x + "," + y + ")";
//            }
//            public int X { get { return x; } }
//        }
//        static void Main(string[] args)
//        {
//            int n = 100;
//            Console.WriteLine("{0} ", n);

//            object o = (object)n; // 명시적인 up_casting
//            int m = (int)o; //down_casting
//            Console.WriteLine("{0} ", m);
//        }
//    }
//}




//// 제네릭 vs 비제네릭
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        class Point
//        {
//            int x, y;
//            public Point(int _x = 0, int _y = 0)
//            {
//                x = _x;
//                y = _y;
//            }
//            public override string ToString()
//            {
//                return "(" + x + "," + y + ")";
//            }
//        }
//        static void Main(string[] args)
//        {
//            Point pt1 = new Point(2, 3);
//            Console.WriteLine(pt1.ToString());

//            object o = pt1;
//            Console.WriteLine(o.ToString());
//        }
//    }
//}



//// 제네릭 vs 비제네릭
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ArrayList arr1 = new ArrayList(); //비제너릭
//            List<int> arr2 = new List<int>(); //제너릭 컬렉션

//            arr1.Add(10);
//            arr1.Add(20);
//            arr1.Add(30);

//            arr2.Add(10);
//            arr2.Add(20);
//            arr2.Add(30);

//            for (int i = 0; i < arr1.Count; ++i)
//                Console.Write("{0} ", arr1[i]);
//            Console.WriteLine();
//            int k = (int)arr1[0];// object 형식을 int형으로 변환해야 한다.

//            for (int i = 0; i < arr2.Count; ++i)
//                Console.WriteLine("{0} ", arr2[i]);
//            Console.WriteLine();
//            int m = arr2[0];
//        }
//    }
//}


//// is 키워드 2
//using System;
//namespace CSharpConsoleApp
//{
//    public struct Point //struct는 일반적으로 필드를 public으로 만든다. 직접 초기화하기위해서
//    {
//        public int x;
//        public int X { get { return x; } set { x = value; } }
//        public int y;
//        public int Y { get { return y; } set { y = value; } }

//        public Point(int _x = 0, int _y = 0)
//        {
//            x = _x;
//            y = _y;
//        }
//        public override string ToString()
//        {
//            return "(" + x + "," + Y + ")";
//        }
//    }
//    class Program
//    {
//        static void Print(params object[] arr) // object 배열이기때문에 모든 형식으로 변환이 되어서 이러한 장점이 있음.
//        {
//            for (int i = 0; i < arr.Length; ++i)
//            {
//                //as 키워는 참조형식에만 값 형식인 struct는 사용안됨
//                if (arr[i] is Point)
//                    Console.WriteLine("{0}, {1}", ((Point)arr[i]).X + 1, ((Point)arr[i]).Y + 1);
//                else
//                    Console.WriteLine("{0} ", arr[i]);
//            }
//        }
//        static void Main(string[] args)
//        {
//            Print("Hello!", 100, new Point(2,3), "ABC", 200, 300);
//        }
//    }
//}



//// is 키워드
//using System;
//namespace CSharpConsoleApp
//{
//    class Point
//    {
//        private int x, y;

//        public Point() { }
//        public Point(int x = 0, int y = 0) { this.x = x; this.y = y; }

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
//        public override string ToString()
//        {
//            return "(" + x + "," + y + ")";
//        }
//    }
//    class Program
//    {
//        static void Print(params object[] arr) // object 배열이기때문에 모든 형식으로 변환이 되어서 이러한 장점이 있음.
//        {
//            for (int i = 0; i < arr.Length; ++i)
//            {
//                Console.WriteLine("{0} ", arr[i]);
//            }
//            Console.WriteLine();

//            int sum = 0;
//            for (int i = 0; i < arr.Length; ++i)
//            {
//                if (arr[i] is int) //형식 변환 연산자
//                    sum += (int)arr[i]; //object->int 로 다운 캐스팅하여 저장.
//            }
//            Console.WriteLine("sum : {0}", sum);
//        }
//        static void Main(string[] args)
//        {
//            Print("Hello!", 100, "ABC", 200, 300);
//        }
//    }
//}


//// params 2
//using System;
//namespace CSharpConsoleApp
//{
//    class Point
//    {
//        private int x, y;

//        public Point() { }
//        public Point(int x = 0, int y = 0) { this.x = x; this.y = y; }

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
//        public override string ToString()
//        {
//            return "(" + x + "," + y + ")";
//        }
//    }
//    class Program
//    {
//        static void Print(params object[] arr) // object 배열이기때문에 모든 형식으로 변환이 되어서 이러한 장점이 있음.
//        {
//            for (int i = 0; i < arr.Length; ++i)
//            {
//                Console.WriteLine("{0} ", arr[i]);
//            }
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            Print("Hello!", 20, 'A', 5.55, new Point(2, 3));
//        }
//    }
//}


//// params
//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Print(params object[] arr) //인수들의 목록을 배열에 받아서 사용할 수 있다.
//        {
//            for (int i = 0; i < arr.Length; ++i)
//            {
//                Console.WriteLine("{0} ", arr[i]);
//            }
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            Print(10, 20, 30);
//            Print(10, 20);
//            Print(10);

//            int[] ar = { 10, 20, 30, 40, 50 };
//            Print(ar); // params가 있기때문에 가능하다.
//            Print(new int[5] { 10, 20, 30, 40, 50 }); // 배열이라는 것을 명확하게 해주기위해 new int[5]를 붙여주면 됨.
//        }
//    }
//}


//// params
//using System; 
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Print(params int[] arr) //인수들의 목록을 배열에 받아서 사용할 수 있다.
//        {
//            for(int i = 0; i < arr.Length; ++i)
//            {
//                Console.WriteLine("{0} ", arr[i]);
//            }
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            Print(10, 20, 30);
//            Print(10, 20);
//            Print(10);

//            int[] ar = { 10, 20, 30, 40, 50 };
//            Print(ar); // params가 있기때문에 가능하다.
//            Print(new int[5] { 10, 20, 30, 40, 50 }); // 배열이라는 것을 명확하게 해주기위해 new int[5]를 붙여주면 됨.
//        }
//    }
//}


//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Add(int a, int b, out int result)
//        {
//            result =  a + b;
//        }
//        static void Main(string[] args)
//        {
//            int a = 10; //int형은 모두 값 객체 => stack에서 stack을 복사
//            int b = 20;

//            int result;
//            Add(a, b, out result);

//            Console.WriteLine("result = {0}", result);
//        }
//    }
//}


//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static int Add(int a, int b)
//        {
//            return a + b;
//        }
//        static void Main(string[] args)
//        {
//            int a = 10; //int형은 모두 값 객체 => stack에서 stack을 복사
//            int b = 20;

//            int result = Add(a, b);

//            Console.WriteLine("result = {0}", result);
//        }
//    }
//}



//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Print(int a, int b)
//        {
//            Console.WriteLine("{0}, {1}", a, b);
//        }
//        static void Swap(ref int a, ref int b)
//        {
//            int temp = a;
//            a = b;
//            b = temp;
//        }
//        static void Main(string[] args)
//        {
//            int a = 10; //int형은 모두 값 객체 => stack에서 stack을 복사
//            int b = 20;

//            Print(a, b);
//            Swap(ref a, ref b);
//            Print(a, b);
//        }
//    }
//}




//using System;
//using CSharpConsoleApp2;
//namespace CSharpConsoleApp
//{
//    internal class Program
//    {
//        /*
//         * class는 레퍼런스 복사
//         * struct 값 복사
//         */
//        static void Main(string[] args)
//        {
//            //구조체는 이미 기본생성자가 예약되어 있기 때문에 만들어 낼 수 없다.
//            Point pt1; // 굳이 new 를 사용하지 않아도 된다는 뜻이다.
//            pt1.x = 2;
//            pt1.y = 3;
//            Point pt2 = pt1;

//            Console.WriteLine(pt1);
//            Console.WriteLine(pt2);
//            Console.WriteLine();

//            pt1.X = 5;
//            pt1.Y = 6;
//            Console.WriteLine(pt1);
//            Console.WriteLine(pt2);
//            Console.WriteLine();
//        }
//    }
//}



//using System;
//using CSharpConsoleApp2;
//namespace CSharpConsoleApp
//{
//    internal class Program
//    {
//        /*
//         * class는 레퍼런스 복사
//         * struct 값 복사
//         */
//        static void Main(string[] args)
//        {
//            Point pt1 = new Point(2, 3); //구조체일 때 객체를 생성한다는 의미에서 new를 사용, heap에 쓴다는 것이 아니다.
//            Point pt2 = pt1;

//            Console.WriteLine(pt1);
//            Console.WriteLine(pt2);
//            Console.WriteLine();

//            pt1.X = 5;
//            pt1.Y = 6;
//            Console.WriteLine(pt1);
//            Console.WriteLine(pt2);
//            Console.WriteLine();
//        }
//    }
//}




//// namespace - 직접 변수 앞에 사용
//using System;
//using CSharpConsoleApp2;
//namespace CSharpConsoleApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Point pt = new Point();
//            pt.X = 10;
//            pt.Y = 20;
//            Console.WriteLine(pt);
//        }
//    }
//}



//// MyMath
//using System;
//namespace CSharpConsoleApp
//{
//    class MyMath
//    {
//        public static int Abs(int input)
//        {
//            if (input < 0)
//                return -input;
//            else
//                return input;
//        }
//        public static double Abs(double input)
//        {
//            if (input < 0)
//                return -input;
//            else
//                return input;
//        }
//        public static long Abs(long input)
//        {
//            if (input < 0)
//                return -input;
//            else
//                return input;
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //int
//            Console.WriteLine(MyMath.Abs(52));
//            Console.WriteLine(MyMath.Abs(-52));

//            //double
//            Console.WriteLine(MyMath.Abs(52.23953452345));
//            Console.WriteLine(MyMath.Abs(-52.239532342345));

//            //long
//            Console.WriteLine(MyMath.Abs(234554535345235));
//            Console.WriteLine(MyMath.Abs(-234554535345235));
//        }
//    }
//}


//// 기본 생성자 
//using System;
//namespace CSharpConsoleApp
//{
//    public class Point
//    {
//        private int x, y;
//        public Point() { }
//        public Point(int _x, int _y)
//        {
//            x = _x;
//            y = _y;
//        }
//        public override string ToString() //모든 형식을 문자열로 바꿀 수 있는 override 사용, 문자열 더하기
//        {
//            return "(" + x + "," + y + ")"; //C#의 문자열은 변경 불가능한 문자열이다.
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
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Point pt1 = new Point() { X = 2, Y = 3 };
//            Point pt1 = new Point { X = 2, Y = 3 };

//            Console.WriteLine("{0}, {1}", pt1.X, pt1.Y);
//        }
//    }
//}


//// getter, setter 하나로 프로퍼티
//using System;
//namespace CSharpConsoleApp
//{
//    public class Point
//    {
//        private int x, y;
//        public Point(int _x = 0, int _y = 0)
//        {
//            x = _x;
//            y = _y;
//        }
//        public override string ToString() //모든 형식을 문자열로 바꿀 수 있는 override 사용, 문자열 더하기
//        {
//            return "(" + x + "," + y + ")"; //C#의 문자열은 변경 불가능한 문자열이다.
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
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Point pt1 = new Point();

//            pt1.X = 1;
//            pt1.Y = 2;
//            Console.WriteLine("{0}, {1}", pt1.X, pt1.Y);
//        }
//    }
//}


//// getter, setter 
//using System;
//namespace CSharpConsoleApp
//{
//    public class Point
//    {
//        private int x, y;
//        public Point(int _x = 0, int _y = 0)
//        {
//            x = _x;
//            y = _y;
//        }
//        public override string ToString() //모든 형식을 문자열로 바꿀 수 있는 override 사용, 문자열 더하기
//        {
//            return "(" + x + "," + y + ")"; //C#의 문자열은 변경 불가능한 문자열이다.
//        }
//        public int GetX() { return x; }
//        public void SetX(int _x) { x = _x; }

//        public int GetY() { return y; }
//        public void SetY(int _y) { y = _y; }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Point pt1 = new Point();

//            pt1.SetX(1);
//            pt1.SetY(2);
//            Console.WriteLine("{0}, {1}", pt1.GetX(), pt1.GetY());
//        }
//    }
//}


//// override
//using System;
//namespace CSharpConsoleApp
//{
//    public class Point : Object //object가 생략되어됨 , 상속하겠다
//    {
//        private int x, y;
//        // ↑Field(정적속성)//↓Method(동적메소드)
//        public Point(int _x = 0, int _y = 0)
//        {
//            x = _x;
//            y = _y;
//        }
//        public override string ToString() //모든 형식을 문자열로 바꿀 수 있는 override 사용, 문자열 더하기
//        {
//            return "(" + x + "," + y + ")"; //C#의 문자열은 변경 불가능한 문자열이다.
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Point pt1 = new Point();
//            Console.WriteLine(pt1);
//        }
//    }
//}



//// <접근 제한자>
///* 1. private : 동일 클래스 내의 멤버만 접근 가능하다.
// * 2. protected : 파생 클래스에서 이 클래스 멤버를 엑세스할 수 있다.
// * 3. public : 모든 외부 혹은 파생 클래스에서 이 클래스를 액세스할 수 있다 
//      (개별 멤버의 액세스 권한은 해당 멤버의 접근 제한자에 따라 별도로 제한된다)
// * 4. internal : 동일한 Assembly 내에 있는 다른 클래스들이 엑세스할 수 있다. 다른 어셈블리에서는 접근 불가
// * 5. protectediternal : 잘 안씀
// * => 다섯가지 모두 멤버 사용가능
// * => 클래스에는 3, 4번만 사용가능 
// * => 내포 클래스에서는 1번도 가능
// */
//using System;
//namespace CSharpConsoleApp
//{
//    class Point : Object //object가 생략되어됨 , 상속하겠다
//    {
//        private int x, y;
//        // ↑Field(정적속성)//↓Method(동적메소드)
//        public Point(int _x=0, int _y = 0)
//        {
//            x = _x;
//            y = _y;
//        }
//        public void Print()
//        {
//            Console.WriteLine("({0}, {1})", x, y);
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Point pt1 = new Point();
//            pt1.Print();
//        }
//    }
//}


//// 가변배열
//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[][] arr = new int[2][];

//            arr[0] = new int[5] { 1, 2, 3, 4, 5 };
//            arr[1] = new int[3] { 4, 6, 8 };

//            for (int i = 0; i < arr.Length; ++i)
//            {
//                for (int j = 0; j < arr[i].Length; ++j)
//                    Console.Write("{0} ", arr[i][j]);
//                Console.WriteLine();
//            }
//        }
//    }
//}


//// 2차원 배열
//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 5, 6, 7 } };

//            for (int i = 0; i < arr.GetLength(0); ++i)
//            {
//                for (int j = 0; j < arr.GetLength(1); ++j)
//                    Console.Write("{0} ", arr[i, j]);
//                Console.WriteLine();
//            }
//        }
//    }
//}

//// 2차원 배열
//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 5, 6, 7 } };

//            for(int i = 0; i < 2; ++i)
//            {
//                for (int j = 0; j < 3; ++j)
//                    Console.Write("{0} ", arr[i, j]);
//                Console.WriteLine();
//            }
//        }
//    }
//}


//// foreach
//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //object[] oarr = new object[5] { 1.2, 100, "ABC", 'A', true };
//            object[] oarr = { 1.2, 100, "ABC", 'A', true }; //생략해서 사용가능!

//            foreach (object o in oarr)
//                Console.WriteLine(o.ToString());
//        }
//    }
//}


//// foreach
//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args) 
//        {
//            //object[] oarr = new object[5] { 1.2, 100, "ABC", 'A', true };
//            object[] oarr = { 1.2, 100, "ABC", 'A', true }; //생략해서 사용가능!

//            foreach (object o in oarr)
//                Console.WriteLine(o);
//        }
//    }
//}

//// foreach
//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args) // string 배열의 참조, 배열은 클래스면서 참조형식이다.
//        {
//            int[] arr = { 10, 20, 30, 40, 50 };
//            foreach (int data in arr) 
//                Console.WriteLine(data);

//            //나열되어 있는 배열에서 각각 하나씩 가져와서 data 에 넣어라
//            //iterator를 사용할 일 없이 자료구조를 사용할 수 있는 장점!
//        }
//    }
//}


//// 배열
//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args) // string 배열의 참조, 배열은 클래스면서 참조형식이다.
//        {
//            Console.WriteLine("string Length : {0}", args.Length); // 프로그램 인수를 입력하지 않았기때문에 0
//            for(int i = 0; i < args.Length; ++i)
//            {
//                Console.Write("{0}", args[i]);
//            }
//            Console.WriteLine();
//        }
//    }
//}



//// 배열
//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void InitArray(int[] arr)
//        {
//            for(int i = 0; i < arr.Length; ++i)
//            {
//                arr[i] = (i + 1) * 10;
//            }
//        }
//        static void PrintArray(int[] arr)
//        {
//            for(int i = 0; i < arr.Length; ++i)
//            {
//                Console.WriteLine("{0} : {1}", i, arr[i]);
//            }
//        }
//        static void Main(string[] args)
//        {
//            int[] arr = new int[5];

//            InitArray(arr);
//            PrintArray(arr);
//        }
//    }
//}


//// 배열
//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //int[] arr = { 10, 20, 30, 40, 50 }; // arr(참조변수)이 int[](10,20,30,40,50)을 참조함(arr[0~4])
//            //int[] arr = new int[5] { 10, 20, 30, 40, 50 };// 정식 코드
//            int[] arr = new int[] { 10, 20, 30, 40, 50 }; // 배열의 갯수 생략 가능
//            for(int i = 0; i < 5; ++i)
//            {
//                Console.WriteLine("{0} : {1}", i, arr[i]);
//            }
//        }
//    }
//}


//// while 문
//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            while(true) //bool 형식만 올 수 있다
//            {
//                string s = Console.ReadLine();
//                if (s == "exit")
//                    return;
//                else
//                    Console.WriteLine("string : {0}", s);
//            }
//        }
//    }
//}

//// for
//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            for(int i = 0; i < 100; ++i)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}


//// switch 
//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string n = "2"; //문자열 형식으로도 가능
//            switch (n)
//            {
//                case "1":
//                    Console.WriteLine("==1==");
//                    break; //C#은 break를 지울 수 없다
//                case "2":
//                    Console.WriteLine("==2==");
//                    break;
//                case "3":
//                    Console.WriteLine("==3==");
//                    break;
//                default:
//                    Console.WriteLine("=====");
//                    break;
//            }
//            Console.WriteLine("End Main");
//        }
//    }
//}



//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = 0;
//            switch(n)
//            {
//                case 1:
//                    Console.WriteLine("==1==");
//                    break; // C#은 break를 지울 수 없다.
//                case 2:
//                    Console.WriteLine("==2==");
//                    break;
//                case 3:
//                    Console.WriteLine("==3==");
//                    break;
//                default:
//                    Console.WriteLine("=====");
//                    break;
//            }
//            Console.WriteLine("End Main");
//        }
//    }
//}


//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var a = 5.5; // 오른쪽 타입을 보고 var의 형식이 정해진다.
//            var b = 500;
//            var c = "ABC";
//            var d = 'A';

//            Console.WriteLine("{0}, {1}, {2}, {3}", a, b, c, d);
//            Console.WriteLine("{0}, {1}, {2}, {3}", a.GetType(), b, c, d); //GetType()은 Type 객체르 반환한다.
//            Console.WriteLine("{0}, {1}, {2}, {3}", a.GetType().Name, b, c, d); // type객체의 이름을 반환한다.

//            Type t = a.GetType();

//            Console.WriteLine(t); //ToString()을 호출해서 문자열로 반환
//            Console.WriteLine(t.Name);
//            Console.WriteLine(t.BaseType.Name); //BaseType은 부모타입을 알려준다.
//            Console.WriteLine(t.BaseType.BaseType.Name); //부모의 부모타입을 알려준다.
//        }
//    }
//}


////var 형식
//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var a = 5.5; // 오른쪽 타입을 보고 var의 형식이 정해진다.
//            var b = 500;
//            var c = "ABC";
//            var d = 'A';

//            Console.WriteLine("{0}, {1}, {2}, {3}", a, b, c, d);
//            Console.WriteLine("{0}, {1}, {2}, {3}", a.GetType(), b, c, d); //GetType()은 Type 객체르 반환한다.
//            Console.WriteLine("{0}, {1}, {2}, {3}", a.GetType().Name, b, c, d); // type객체의 이름을 반환한다.
//        }
//    }
//}


////bool 형식(TRUE or FALSE)
//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            bool b = true;

//            Console.WriteLine(b);
//        }
//    }
//}



////비트연산
//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n1 = 0x1234;    //0001 0010 0011 0100
//            int n2 = 0x5678;    //0101 0110 0111 1000
//                                //0101 0110 0111 1100
//                                // 5    6    7    C

//            int r = n1 | n2;
//            Console.WriteLine("{0}, {1:x}", r, r); //1:x -> 16진수
//        }
//    }
//}


//// 값 형식을 -> 참조형식 Boxing
//using System;
//namespace CSharpConsoleApp 
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = 100;
//            double d = 5.5;

//            object o1 = n; //object(부모형식)을 상속받기 때문에 가능하다. 자식형식을 부모형식으로 형변환
//            object o2 = d; //주의할점은 값형식(stack)을 참조형식(heap)으로 변환하기 위한 작업과정 박싱이 수행된다.

//            Console.WriteLine("{0}, {1}", o1, o2);
//        }
//    }
//}



//// 값형식과 참조형식
//using System;
//namespace CSharpConsoleApp 
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = 100;
//            double d = 5.5;

//            string sn = n.ToString(); // 정수를 문자열 형식으로
//            System.String sd = d.ToString(); // 실수를 문자열 형식으로

//            int n2 = int.Parse(sn); // 문자열을 정수 형식으로
//            double d2 = double.Parse(sd); // 문자열을 실수로

//            Console.WriteLine("{0}, {1}", n2, d2);
//            /*
//             * 기본형식(내장)
//             *     값 형식(객체를 값으로 다룸)
//             *      -bool, char, int, double ... etc
//             *     
//             *     참조형식(객체를 참조로 다룸)
//             *      -string, object
//             */
//        }
//    }
//}



//// GetType.Name
//using System;
//namespace CSharpConsoleApp 
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Int32 n = 100;
//            System.Double d = 5.5;

//            Console.WriteLine(n.GetType().Name);
//            Console.WriteLine(d.GetType().Name);
//            Console.WriteLine(100.GetType().Name);
//            Console.WriteLine((5.5).GetType().Name);
//        }
//    }
//}



//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = 100;
//            double d = 5.5;

//            Console.WriteLine(n.ToString());
//            Console.WriteLine(d.ToString());
//            Console.WriteLine(100.ToString());
//            Console.WriteLine((5.5).ToString());
//            //ToString() - virtual method은 문자열로 바꾸어주는 역할
//        }
//    }
//}



//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = 100;
//            double d = 5.5;

//            Console.WriteLine(n);
//            Console.WriteLine(d);
//        }
//    }
//}



//// 정수 및 실수 입력
//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("실수 입력 : ");
//            double n1 = double.Parse(Console.ReadLine());

//            Console.Write("실수 입력 : ");
//            double n2 = double.Parse(Console.ReadLine());

//            double sum = n1 + n2;
//            Console.WriteLine("{0} + {1} = {2}", n1, n2, sum);
//        }
//    }
//}

//// 문자 입력
//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int c = Console.Read();

//            Console.WriteLine("string : {0}", (char)c); // 아스키 코드값을 확인할 수 있다.
//            Console.WriteLine("string : {0}", c); // 아스키 코드값을 확일 할 수 있다.
//        }
//    }
//}



//// 문자열 입력
//using System; 
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("문자열 입력: ");
//            string s = Console.ReadLine(); // C#에서 모든 입력은 이 명령어를 사용한다.
//            Console.WriteLine("string : {0}", s);
//        }
//    }
//}


//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write(100);
//            Console.Write('A');
//            Console.Write("ABCD\n");
//            Console.Write("abcd\n");
//        }
//    }
//}


//using System;
//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello!");
//            Console.WriteLine("{0}, {1}", "ABC", 100);
//            Console.WriteLine("{0}, {1}, {0}", "ABC", 100);
//        }
//    }
//}


//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Print() // 객체 것이 아닌 독립적으로 존재하는 클래스의 것(static)
//        {
//            System.Console.WriteLine("Hello!");
//            System.Console.WriteLine(100);
//            System.Console.WriteLine(3.55);
//            System.Console.WriteLine('A');
//        }
//        static void Main(string[] args) //main 함수는 static이어야 한다.
//        {
//            Print(); // 프로그램이라는 클래스 안에 있어서 사용 가능
//            Program.Print();
//            CSharpConsoleApp.Program.Print(); // 정식 풀 Name
//        }
//    }
//}



////namespace 가 없을 떄
//namespace CSharpConsoleApp 
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Console.WriteLine("Hello!");
//            System.Console.WriteLine(100);
//            System.Console.WriteLine(3.55);
//            System.Console.WriteLine('A');
//        }
//    }
//}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello!");
//            Console.WriteLine(100);
//            Console.WriteLine(3.55);
//            Console.WriteLine('A');
//        }
//    }
//}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello!");
//        }
//    }
//}
