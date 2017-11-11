//var 형식
using System;
namespace CSharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5.5; // 오른쪽 타입을 보고 var의 형식이 정해진다.
            var b = 500;
            var c = "ABC";
            var d = 'A';

            Console.WriteLine("{0}, {1}, {2}, {3}", a, b, c, d);
            Console.WriteLine("{0}, {1}, {2}, {3}", a.GetType(), b, c, d); //GetType()은 Type 객체르 반환한다.
            Console.WriteLine("{0}, {1}, {2}, {3}", a.GetType().Name, b, c, d); // type객체의 이름을 반환한다.
        }
    }
}


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
