using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
  class HahTable
  {
    static void Main2(string[] args)
    {
      Hashtable ht = new Hashtable();
      ht.Add("v1", new Person("h1", 11));
      ht.Add("v2", new Person("h2", 13));
      ht.Add("v3", new Person("h3", 19));
      ht.Add(13, new Person("h4", 10));
      foreach (DictionaryEntry h in ht)
      {
        Console.WriteLine(h.Key + " " + h.Value);
      }
      //
      Console.WriteLine("-------------------------------");
      Person new_p = new Person("h5", 9);
      ht["v1"] = new_p;
      foreach (DictionaryEntry h in ht)
      {
        Console.WriteLine(h.Key + " " + h.Value);
      }
      ht.Remove("v2");
      foreach (DictionaryEntry h in ht)
      {
        Console.WriteLine(h.Key + " " + h.Value);
      }
      Console.WriteLine("------------SortedList -------------------");
      SortedList st = new SortedList(new SortPerson());
      st.Add(new Person("hai", 7), 13);
      st.Add(new Person("hai", 0), 17);
      st.Add(new Person("hai", 9), 33);

      foreach (DictionaryEntry dt in st)
      {
        Console.WriteLine(dt.Key + "   " + dt.Value);
      }
      Console.WriteLine("------------Generic List<T> -------------------");
      List<Person> lp = new List<Person>() {
        { new Person("h1",1)},
        { new Person("h2", 2)},
        { new Person("h3", 3)},
        { new Person("h2", 4)}
      };
      Dictionary<int, Person> dic = new Dictionary<int, Person>()
      {
        {1,new Person("h1",23) },
        {2,new Person("h2",20) },
        {3,new Person("h3",29) },
      };
      foreach(KeyValuePair<int,Person> kp in dic)
      {
        Console.WriteLine(kp.Key+" "+kp.Value);
      }
    }
  }
}
