using System.Data.SqlClient;

namespace test_team1.Dal
{
    public static class DatabaseSetup
    {
        public static void CreateTable()
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                var createTableCommand = @"
                    CREATE TABLE Students (
                        Id INT PRIMARY KEY IDENTITY,
                        Name NVARCHAR(100) NOT NULL,
                        Age INT NOT NULL,
                        Email NVARCHAR(100) NOT NULL
                    )";

                using (var command = new SqlCommand(createTableCommand, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void InsertSampleData()
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                var insertDataCommand = @"
                    INSERT INTO Students (Name, Age, Email)
                    VALUES
                        ('Alice Smith', 20, 'alice.smith@example.com'),
                        ('Bob Johnson', 22, 'bob.johnson@example.com'),
                        ('Charlie Brown', 19, 'charlie.brown@example.com')";

                using (var command = new SqlCommand(insertDataCommand, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
