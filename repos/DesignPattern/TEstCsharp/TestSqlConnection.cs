using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TEstCsharp
{
  class TestSqlConnection
  {
    public static SqlConnection GetDBConnection(string datasource, string database)
    {
      //
      // Data Source=ADMIN\SQLEXPRESS;Initial Catalog=simplehr;Persist Security Info=True;User ID=sa;Password=12345
      //connectionString="data source=ADMIN\SQLEXPRESS;initial catalog=RealOnlineShop;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />
      //
      string connString = @"Data Source=" + datasource + ";Initial Catalog="
                  + database + ";Integrated Security=SSPI";

      SqlConnection conn = new SqlConnection(connString);

      return conn;
    }
  }
}
