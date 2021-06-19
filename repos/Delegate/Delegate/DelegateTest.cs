using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
  public class DelegateTest
  {
    private delegate int Add(int a, int b);

    public void Run()
    {
      var operation = new Add(AddOperation);

      Console.WriteLine(operation(4, 5));

      if (operation != null) Console.WriteLine(operation.Invoke(4, 6));
    }

    private int AddOperation(int x, int y)
    {
      return x + y;
    }
  }
}
