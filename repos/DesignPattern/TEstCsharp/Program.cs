using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEstCsharp
{
  class Program
  {
    static void Main(string[] args)
    {
      //connectionString="data source=ADMIN\SQLEXPRESS;initial catalog=RealOnlineShop;integrated security=True
      SqlConnection conn = TestSqlConnection.GetDBConnection("ADMIN\\SQLEXPRESS", "RealOnlineShop");
      conn.Open();
      string sql = "Select * from [RealOnlineShop].[dbo].[User]";
      SqlCommand cmd = conn.CreateCommand();
      cmd.CommandText = sql;
      using (DbDataReader reader = cmd.ExecuteReader())
      {
        if (reader.HasRows)
        {

          while (reader.Read())
          {
            int userIdIndex = reader.GetOrdinal("ID");
            long IdValue = Convert.ToInt64(reader.GetValue(userIdIndex));
            int empNameIndex = reader.GetOrdinal("Username");
            string empName = reader.GetString(empNameIndex);
            Console.WriteLine($"ID = {IdValue}, Name = {empName}");
          }
        }
      }
    }
  }
}
