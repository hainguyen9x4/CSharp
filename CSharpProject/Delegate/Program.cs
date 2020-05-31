using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        public delegate void PrintString(string strString);
        static void Main(string[] args)
        {
            PrintString PrintString1, PrintString2, PrintString0;
            PrintString1 = Print1;
            PrintString1("Message 1");
            PrintString2 = Print2;
            PrintString2("Message 2");
            PrintString2 += Print1;
            PrintString2("Message all");
            //
            PrintString0 = Print1;
            string str = "deleagete";
            //PrintString0 += (str);
            Console.WriteLine("Func---------------------------------------------");
            Func<int, int> Func1;
            Func1 = Sum1;
            Console.WriteLine("Value1 = " + Func1(1));
            Func<int, int,int> Func2;
            Func2 = Sum2;
            Console.WriteLine("Value2 = " + Func2(1,99));
            Func<int, int, string> Func3;
            Func3 = Tinhtong;
            Console.WriteLine("Value2 = " + Func3(1, 99));
            Console.WriteLine("Action---------------------------------------------");
            Action<string> Action1;
            Action1 = Print1;
            Action1("hello world");
            Console.ReadKey();
        }
        public static  void Print1(string strMessage1)
        {
            Console.WriteLine(string.Format("===>{0}<===", strMessage1));
        }
        public static int Sum1(int a)
        {
            return a +100;
        }
        public static int Sum2(int a,int b)
        {
            return a + b;
        }
        public static string Tinhtong(int a, int b)
        {
            return "Ket qua "+(a + b);
        }
        public static  void Print2(string strMessage2)
        {
            Console.WriteLine("Thong bao 1:"+strMessage2);
        }
    }
}
