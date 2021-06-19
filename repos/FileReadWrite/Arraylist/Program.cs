using System;
using System.Collections;
using System.Collections.Generic;

namespace Arraylist
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      ArrayList list = new ArrayList();
      list.Add(new Student(1,"NguyenVanHai"));
      list.Add(new Student(2, "NguyenVanHai2"));
      list.Add(14);
      list.Add("TestDataList");
      for(int i = 0; i < list.Count - 1; i++)
      {
        Console.WriteLine(list[i]);
      }
      for(int i = 0; i < 100; i++)
      {
        list.Add(i);
      }



      IList list2 = new ArrayList();
      list2.Add(new Student(1, "NguyenVanHai"));
      list2.Add(new Student(2, "NguyenVanHai2"));
      list2.Add(14);
      for (int i = 0; i < list.Count - 1; i++)
      {
        Console.WriteLine(list2[i]);
      }
    }
  }
  class Student
  {
    int id;
    string name;
    public Student(int id, string name)
    {
      this.id = id;
      this.name = name;
    }
    public override string ToString() {
      return "ID: " + id + "|Name: " + name;
    }
  }
}

