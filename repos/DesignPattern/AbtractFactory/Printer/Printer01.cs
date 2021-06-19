using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtractFactory
{
  public class Printer01: Printer
  {
    public Printer01()
    {
      Console.WriteLine("Printer01");
    }

    public void PrintImg()
    {
      throw new NotImplementedException();
    }

    public void PrintText()
    {
      throw new NotImplementedException();
    }
  }
}
