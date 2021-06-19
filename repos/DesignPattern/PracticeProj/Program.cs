using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProj
{
  class Program
  {
    static void Main(string[] args)
    {
      Number? value =null;
      Method01(ref value);
      Console.WriteLine("Value:"+ value.number);
      /*Test Serialization*/
      TestBinaryFormatterSerialization t = new TestBinaryFormatterSerialization();
      t.Method01();
      t.Method02();
      XmlSerializerTest t2 = new XmlSerializerTest();
      t2.Method01();
      t2.Method02();
      Console.ReadKey();
    }
    static void Method01(ref Number number)
    {
      if(number != null)
      {
        number.number = 12;
      }
      else
      {
        number = new Number();
        number.number = 0;
      }
    }
    class Number
    {
      public int number;
    }
  }
}
