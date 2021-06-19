using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
  class Delegate
  {
    
    public delegate int MyDelegateConvert(string str);
    static void Main(string[] args)
    {
      MyDelegateConvert d = new MyDelegateConvert(ConvertToInt);
      d += ShowData;
      Execute(d);
      TestEvent t = new TestEvent();
      t.settingNotify();
    }

    static int ConvertToInt(string str)
    {
      int result;
      int.TryParse(str, out result);
      return result;
    }
    static int ShowData(string str)
    {
      int result = 0;
      Console.WriteLine("string data: "+str);
      return result;
    }
    static void Execute(MyDelegateConvert convert)
    {
      string str = "28";
      convert(str);
    }
  }
  class Object1
  {
    public Object1()
    {
     
    }
    public event EventHandler<int> event1;
    public void NotifyEvent()
    {
      EventHandler<int> event_handler = event1;
      event_handler?.Invoke(this, 14);

    }
  }
  class TestEvent
  {
    Object1 d_o = new Object1();
    public TestEvent()
    {
      d_o.event1 += OnReceiveEvent;
    }

    private void OnReceiveEvent(object sender, int e)
    {
      Console.WriteLine("Data Event: "+ e);
    }
    public void settingNotify()
    {
      d_o.NotifyEvent();
    }
    }
}
