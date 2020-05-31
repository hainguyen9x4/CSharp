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
        delegate int IntToInt(int a,int b);
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
            Console.WriteLine("--------------------------------------------------------");
            //IntToInt IntToInt1 = new IntToInt(Operation.Sum);
            IntToInt IntToInt1 = Operation.Sum;
            Console.WriteLine("Value "+IntToInt1(2, 3));
            Console.ReadKey();
        }
        public static  void Print1(string strMessage1)
        {
            Console.WriteLine(string.Format("===>{0}<===", strMessage1));
        }
        public static  void Print2(string strMessage2)
        {
            Console.WriteLine("Thong bao 1:"+strMessage2);
        }
    }
}
