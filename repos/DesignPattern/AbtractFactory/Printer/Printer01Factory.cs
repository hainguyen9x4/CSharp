using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtractFactory
{
  class Printer01Factory : AbtractPrinterFactory
  {
    public Printer CreatePrinter()
    {
      return new Printer01();
    }
  }
}
