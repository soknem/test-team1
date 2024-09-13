using System.Data.SqlClient;

namespace test_team1.Dal
{
    public static class DatabaseConnection
    {
        private static readonly string connectionString = "Server=68.183.187.158;Database=school;User Id=sa;Password=Soknem@123;";

        public static SqlConnection GetConnection()
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
