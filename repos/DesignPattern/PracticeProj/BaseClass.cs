using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProj
{
  class BaseClass
  {
    public void Method01()
    {

    }
    public virtual void Method02()
    {

    }
  }
  abstract class BaseClassAbstract
  {
    public void Method01()
    {

    }
    public virtual void Method03()
    {
    }
    public abstract void Method02();
  }
}
