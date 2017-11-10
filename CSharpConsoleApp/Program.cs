namespace CSharpConsoleApp
{
    class Program
    {
        void Print()
        {
            System.Console.WriteLine("Hello!");
            System.Console.WriteLine(100);
            System.Console.WriteLine(3.55);
            System.Console.WriteLine('A');
        }
        static void Main(string[] args)
        {
            Program pro = new Program(); // 프로그램 객체를 생성하여 호출해야 한다.
                                         // 모든 객체는 new를 사용해서 호출!  value object , reference object 두개 다 사용할 수 있다.
            pro.Print();
        }
    }
}



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
