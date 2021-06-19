using System;

namespace Delegate
{
  class Test
  {
    public static int Count = 0;
    public void Hello()
    {
      Count++;
      Console.WriteLine("Hello " + Count);
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Test t1 = new Test();
      t1.Hello();
      t1.Hello();
      Test t2 = new Test();
      t2.Hello();
      Test t3 = new Test();
      t3.Hello();
    }
  }
}
