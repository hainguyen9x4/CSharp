using System;
using System.Collections.Generic;
using System.Text;

namespace TApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      StringBuilder strText = new StringBuilder("Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.");
      string str = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
      string[] str_tem = str.Split(' ');
      int lenght_max = 0;
      List<int> indexs = new List<int>();
      int current_lenght = 0;
      for(int i =0;i<str_tem.Length -1 ;i++)
      {
        if(current_lenght > str_tem[i].Length)
        {
         
          
        }
        else if(current_lenght == str_tem[i].Length)
        {
          indexs.Add(i);
        }
        else
        {
          current_lenght = str_tem[i+1].Length;
          indexs.Clear();
        }
      }
      foreach(int i in indexs)
      {
        Console.WriteLine(str_tem[i]);
      }

    }
  }
}
