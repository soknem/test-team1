using System.Data.SqlClient;

namespace test_team1.Dal
{
    public static class DatabaseConnection
    {
        private static readonly string server = "68.183.187.158";
        private static readonly string database = "school";
        private static readonly string userId = "sa";
        private static readonly string password = "Soknem@123";

        // Combine into a single connection string
        private static readonly string connectionString =
            $"Server={server};Database={database};User Id={userId};Password={password};";
        public static SqlConnection GetConnection()
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
