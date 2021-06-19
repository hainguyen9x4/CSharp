using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadWithTask
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Task t1 = Task01();
      Task t2 = Task02();


      Task<string> t3 = new Task<string>(
        () =>
        {
          Console.WriteLine("T3 is running!");
          return "T3";
        });
      t3.Start();
      Task<string> t4 = new Task<string>(
  (Object ob) =>{
    Console.WriteLine("T4 is running!:" + ob);
    return "T4";
  }, "T4");
      t4.Start();
      Console.WriteLine("Main end!");

      Thread.Sleep(15000);
    }
    static async Task Task01()
    {
      Task t = new Task(() =>
      {
        for (int i = 0; i < 5; i++)
        {
          Console.WriteLine("Task01: " + i);
          Thread.Sleep(500);
        }
      });
      t.Start();
      await t;
      Console.WriteLine("T01 is end!");

    }
    static async Task Task02()
    {
      Task t2 = new Task(() =>
      {
        for (int i = 0; i < 5; i++)
        {
          Console.WriteLine("-Task02: " + i);
          Thread.Sleep(1000);
        }
      });
      t2.Start();
      await t2;
      Console.WriteLine("T02 is end!");

    }
  }
}
