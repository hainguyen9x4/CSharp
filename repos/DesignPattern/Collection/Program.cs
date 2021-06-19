using System;
using System.Collections;

namespace Collection
{
 public class Program
  {
    static void Main1(string[] args)
    {
      Console.WriteLine("Hello World!");
      ArrayList arr = new ArrayList();
      arr.Add(12);
      arr.Add(15);
      arr.Add(13);
      //ArrayList arr2 = (ArrayList)arr.Clone();
      //arr2[0] = 13;
      //arr2[1] = "hainguye";
      //for (int i=0;i< arr.Count; i++)
      //{
      //  Console.WriteLine(arr2[i]);
      //}
      arr.Sort();
      for (int i = 0; i < arr.Count; i++)
      {
        Console.WriteLine(arr[i]);
      }
      ArrayList personList = new ArrayList();
      personList.Add(new Person("Hai", 12));
      personList.Add(new Person("Hai", 15));
      personList.Add(new Person("Hai", 11));
      personList.Sort(new SortPerson());
      for (int i = 0; i < arr.Count; i++)
      {
        Console.WriteLine(personList[i]);
      }
      Console.WriteLine("-------------------------------------");
      personList.Sort();
      for (int i = 0; i < arr.Count; i++)
      {
        Console.WriteLine(personList[i]);
      }
    }
  }
public class Person : IComparable<Person>
  {
    public string name;
    public int age;
    public Person(string name, int age)
    {
      this.name = name;
      this.age = age;
    }

    public int CompareTo(Person other)
    {
      if (this.age > other.age)
      {
        return 1;
      }
      else if (this.age == other.age)
      {
        return 0;
      }
      else
      {
        return -1;
      }
    }

    public override string ToString()
    {
      return name + age.ToString();
    }
  }
  class SortPerson : IComparer
  {
    public int Compare(object x, object y)
    {
      Person p1 = (Person)x;
      Person p2 = (Person)y;
      if (p1.age > p2.age)
      {
        return 1;
      }
      else if (p1.age < p2.age)
      {
        return -1;
      }
      else
      {
        return 0;
      }
    }
  }
}

