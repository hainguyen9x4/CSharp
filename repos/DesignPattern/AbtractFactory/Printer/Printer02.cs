using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtractFactory
{
  public class Printer02: Printer
  {
    public Printer02()
    {
      Console.WriteLine("Printer02");
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
