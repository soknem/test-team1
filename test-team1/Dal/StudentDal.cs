using System.Collections.Generic;
using System.Data.SqlClient;
using test_team1.Model;

namespace test_team1.Dal
{
    public class StudentDAL
    {
        public List<Student> GetAllStudents()
        {
            var students = new List<Student>();
            using (var connection = DatabaseConnection.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Students", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    students.Add(new Student
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        Age = (int)reader["Age"],
                        Email = reader["Email"].ToString()
                    });
                }
            }
            return students;
        }

        public void AddStudent(Student student)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                var command = new SqlCommand("INSERT INTO Students (Name, Age, Email) VALUES (@Name, @Age, @Email)", connection);
                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@Age", student.Age);
                command.Parameters.AddWithValue("@Email", student.Email);
                command.ExecuteNonQuery();
            }
        }
    }
}
