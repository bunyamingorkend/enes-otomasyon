using System.Data;
using System.Data.SqlClient;

namespace projenes.Connection;

public class SqlDbConnection
{
    SqlConnection baglan;
    private string dynamicConnectionString;
    string connectionString = string.Empty;
    public SqlDbConnection(string dbName)
    {
        dynamicConnectionString = dbName;
    }

    public SqlConnection Connect()
    {
        if (baglan?.State != ConnectionState.Open)
        {
            connectionString = $"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog={dynamicConnectionString};Integrated Security=True";

            baglan = new SqlConnection(connectionString);
            baglan.Open();
        }

        return baglan;
    }
}
