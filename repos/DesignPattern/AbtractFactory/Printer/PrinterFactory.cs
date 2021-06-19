using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtractFactory
{
  public class PrinterFactory
  {
    public static Printer CreatePrinter(AbtractPrinterFactory printer_fac)
    {
      return printer_fac.CreatePrinter();
    }
  }
}
