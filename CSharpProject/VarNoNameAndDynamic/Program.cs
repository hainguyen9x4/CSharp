using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarNoNameAndDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new
            {
                abc = 123,
                str = "Hello"
            };
            TestFunc(obj);
            Console.ReadKey();
        }
        static void TestFunc(dynamic dvar)
        {
            Console.WriteLine(dvar.abc);
        }
    }
}
