using System;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      string[] str_array = new string[10];
      int[] int_array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
      int[] int_array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
      str_array.SetValue("hai", 0);
      str_array.SetValue("hai1", 1);
      str_array.SetValue("hai2", 2);
      for (int i = 0; i < str_array.Length; i++)
        Console.WriteLine(str_array[i]);
      foreach (var str in str_array)
      {
        Console.WriteLine(str);
      }
      int[,] array2;
      int[,] array2_1 = new int[3, 4];
      int[,] @array2_2 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
      //
      StringBuilder @string_builder = new StringBuilder("This is string!");
      @string_builder.AppendFormat("haiNV");
      Console.WriteLine(@string_builder);
      int[,] aa = new int[2, 3] {
                                  { 1,2,3},
                                  {2,3 ,4}
                                  };


      //int[][][] a1 = new int[2][2][2];
      //int[,,] a2 = new int[2, , ];
      //int[2, 2, 2] a3 = new int[,,];


      // What Will Be The Output Of The Following Code Snippet?
      int ii = 30;
      int j = 5 % 5;
      if (Convert.ToBoolean(1))
      {
        Console.Write("0");
      }
      else
      {
        Console.Write("1");
      }
      Console.Write("2");
      float x = 0.0f, y = 0.0f;
      Console.WriteLine(x / y);
      string reallyLongString = "abcsdfghjkdfghjk";
      string abc = "abc";
      StringBuilder sb = new StringBuilder("abcsdfghjkdfghjk");
      Console.WriteLine("-------------------------");
      Console.WriteLine(sb.Equals("abc"));
    }

  }
  public abstract class class01 :Program{
    }
}
