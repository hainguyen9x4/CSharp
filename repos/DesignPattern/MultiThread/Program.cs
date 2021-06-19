using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThread
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Thread newThread = new Thread(writeB);
      Thread newThreadA = new Thread(writeA);

      Work w = new Work();
      Thread tw = new Thread(w.DoWork);
      
      Thread newThread1 = new Thread(
        delegate(object value)
        {
          for (int i = 0; i < 10; i++)
            Console.WriteLine("Thread with delegate funtion:"+ value+Thread.CurrentThread.Name);
          Thread.Sleep(70);
        }
        );
      newThread1.Priority = ThreadPriority.Highest;
      newThread1.Name = "delegate";
     
      newThread.Start("B running");
      
      tw.Start("Do work...");
      tw.Join();
      newThreadA.Start("A running");
      newThread1.Start("hainguyen");
      newThreadA.Join();
      Task t1 = new Task(
        ()=>{
          for(int i = 0; i < 5; i++)
          {
            Console.WriteLine("t1" + i);
            Thread.Sleep(1000);
          }
        });
      t1.Start();
      t1.Wait();
    }

    private static void writeA(object obj)
    {
      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine("Thread write A:" + obj);
        Thread.Sleep(70);
      }
    }

    private static void writeB(object obj)
    {
      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine("Thread write B:" + obj);
        Thread.Sleep(70);
      }
    }
  }
  public class Work
  {
    public void DoWork(object name)
    {
      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine("Do work: " + name);
        Thread.Sleep(70);
      }
    }
  }
}
