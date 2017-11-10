// GetType.Name
using System;
namespace CSharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Int32 n = 100;
            System.Double d = 5.5;

            Console.WriteLine(n.GetType().Name);
            Console.WriteLine(d.GetType().Name);
            Console.WriteLine(100.GetType().Name);
            Console.WriteLine((5.5).GetType().Name);
        }
    }
}



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
