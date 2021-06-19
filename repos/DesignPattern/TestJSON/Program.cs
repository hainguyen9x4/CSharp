using Newtonsoft.Json;
using System;

namespace TestJSON
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      // Khởi tạo một đối tượng 
      var objEm = new Employee()
      {
        Name = "hoctoantap.com",
        Age = 20,
        IsBoss = false,
        Salary = 1000.5
      };
     string strEm = JsonConvert.SerializeObject(objEm);

      Employee em = JsonConvert.DeserializeObject<Employee>(strEm);
      
      int x = 1;

    }
  }
  public class Employee
  {
    public string Name { get; set; }

    public int Age { get; set; }

    public bool IsBoss { get; set; }

    public double Salary { get; set; }
  }
}
