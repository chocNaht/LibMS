using Microsoft.Data.SqlClient;

namespace LibMS.DBData
{
    public static class Database
    {
        private static readonly string ConnectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=C:\Users\user\Desktop\LibMS\LibMS\App_Data\db_LibMS.mdf;
              Integrated Security=True;
              Connect Timeout=30";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}