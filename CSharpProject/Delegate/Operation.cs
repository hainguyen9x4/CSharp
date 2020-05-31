using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Operation
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Div(int a, int b)
        {
            return a / b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Mul(int a, int b)
        {
            return a * b;
        }
    }
}
