using System;
using System.IO;

namespace FileReadWrite
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      using (FileStream fileStream = new FileStream(@"D:\TestStreamFile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
      {
        string str = "Test Write to file";
        foreach (char c in str)
        {
          fileStream.WriteByte((byte)c);
        }
      }
      using (StreamWriter streamWriter = new StreamWriter(@"D:\TestStreamFile.txt", true, System.Text.Encoding.UTF8))
      {
        streamWriter.WriteLine("Ghi vaof file lần nữa!");
      }
      File.Exists(@"D:\TestStreamFile.txt");

    }
  }
}
