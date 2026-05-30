using Microsoft.Data.SqlClient;

namespace LibMS.DBData
{
    public class UserRepository
    {
        public bool UserExists(string email, string password)
        {
            using SqlConnection conn = Database.GetConnection();

            conn.Open();

            string query = @"
                SELECT COUNT(*)
                FROM Users
                WHERE Email = @Email
                AND Pass = @Password";

            using SqlCommand cmd = new(query, conn);

            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            return count > 0;
        }

        public string? GetUserRole(string email, string password)
        {
            using SqlConnection conn = Database.GetConnection();

            conn.Open();

            string query = @"
                SELECT Roles
                FROM Users
                WHERE Email = @Email
                AND Pass = @Password";

            using SqlCommand cmd = new(query, conn);

            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);

            object? result = cmd.ExecuteScalar();

            return result?.ToString();
        }
    }
}