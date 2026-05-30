using Microsoft.Data.SqlClient;

namespace LibMS.DBData
{
    public class UserRepository
    {
        public bool ValidateUser(
            string email,
            string password,
            string role)
        {
            using SqlConnection conn = Database.GetConnection();

            conn.Open();

            string query = @"
                SELECT COUNT(*)
                FROM Users
                WHERE Email = @Email
                  AND Pass = @Password
                  AND Roles = @Role";

            using SqlCommand cmd = new(query, conn);

            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Role", role);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            return count > 0;
        }
    }
}