using System.Data.SqlClient;

namespace AtYarisiYeni.Helpers
{
    public class ConnectionHelper
    {
        public SqlConnection con =
            new SqlConnection("Data Source=ilkan-pc\\SQLEXPRESS;Initial Catalog=HorseDB;Integrated Security=True");
    }
}
