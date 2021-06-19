using System;
namespace AbtractFactory
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Printer p1 = PrinterFactory.CreatePrinter(new Printer01Factory());
      Printer p2 = PrinterFactory.CreatePrinter(new Printer02Factory());
      Console.ReadLine();
    }
  }
}
