using LibMS.Models;
using Microsoft.Data.SqlClient;

namespace LibMS.DBData
{
    public class BookRequestRepository
    {
        // Create a new book request for a user
        public int CreateRequest(
            int userId,
            int bookId)
        {
            using SqlConnection conn =
                Database.GetConnection();

            conn.Open();

            string query = @"
            INSERT INTO Request
            (
                UserID,
                BookID,
                Status
            )
            OUTPUT INSERTED.RequestID
            VALUES
            (
                @UserID,
                @BookID,
                'Pending'
            )";

            using SqlCommand cmd =
                new(query, conn);

            cmd.Parameters.AddWithValue(
                "@UserID",
                userId);

            cmd.Parameters.AddWithValue(
                "@BookID",
                bookId);

            return Convert.ToInt32(
                cmd.ExecuteScalar());
        }

        public bool SubmitReturnRequest(
    int requestId)
        {
            using SqlConnection conn =
                Database.GetConnection();

            conn.Open();

            string query =
            @"
    UPDATE Request
    SET Status = 'Return Pending'
    WHERE RequestID = @RequestID
    ";

            using SqlCommand cmd =
                new(query, conn);

            cmd.Parameters.AddWithValue(
                "@RequestID",
                requestId);

            return cmd.ExecuteNonQuery() > 0;
        }

        public void CancelRequest(int requestId)
        {
            using SqlConnection conn =
                Database.GetConnection();

            conn.Open();

            string query = @"
        DELETE FROM Request
        WHERE RequestID = @RequestID";

            using SqlCommand cmd =
                new(query, conn);

            cmd.Parameters.AddWithValue(
                "@RequestID",
                requestId);

            cmd.ExecuteNonQuery();
        }

        // Additional methods for updating requests, fetching user requests, etc. can be added here
        public BookRequest? GetRequestById(int requestId)
        {
            using SqlConnection conn =
                Database.GetConnection();

            conn.Open();

            string query = @"
    SELECT
        r.RequestID,
        r.BookID,
        b.Title,
        r.BorrowDate,
        r.ReturnDate,
        r.Status
    FROM Request r
    INNER JOIN Books b
        ON r.BookID = b.BookID
    WHERE r.RequestID = @RequestID";

            using SqlCommand cmd =
                new(query, conn);

            cmd.Parameters.AddWithValue(
                "@RequestID",
                requestId);

            using SqlDataReader reader =
                cmd.ExecuteReader();

            if (!reader.Read())
                return null;

            return new BookRequest
            {
                RequestID =
                    Convert.ToInt32(
                        reader["RequestID"]),

                BookID =
                    Convert.ToInt32(
                        reader["BookID"]),

                BookTitle =
                    reader["Title"].ToString()!,

                BorrowDate =
                    Convert.ToDateTime(
                        reader["BorrowDate"]),

                ReturnDate =
                    Convert.ToDateTime(
                        reader["ReturnDate"]),

                Status =
                    reader["Status"].ToString()!
            };
        }

        public bool UpdateRequest(
    int requestId,
    int bookId,
    DateTime borrowDate,
    DateTime returnDate)
        {
            using SqlConnection conn =
                Database.GetConnection();

            conn.Open();

            string query =
            @"
    UPDATE Request
    SET
        BookID = @BookID,
        BorrowDate = @BorrowDate,
        ReturnDate = @ReturnDate
    WHERE RequestID = @RequestID
    ";

            using SqlCommand cmd =
                new(query, conn);

            cmd.Parameters.AddWithValue(
                "@RequestID",
                requestId);

            cmd.Parameters.AddWithValue(
                "@BookID",
                bookId);

            cmd.Parameters.AddWithValue(
                "@BorrowDate",
                borrowDate.Date);

            cmd.Parameters.AddWithValue(
                "@ReturnDate",
                returnDate.Date);

            return cmd.ExecuteNonQuery() > 0;
        }

        public List<ActivityLogModel> GetActivityLogs(
    int userId)
        {
            List<ActivityLogModel> logs = new();

            using SqlConnection conn =
                Database.GetConnection();

            conn.Open();

            string query =
            @"
    SELECT
        r.RequestID,
        b.Title,
        r.BorrowDate,
        r.ReturnDate,
        r.Status
    FROM Request r
    INNER JOIN Books b
        ON r.BookID = b.BookID
    WHERE r.UserID = @UserID
    ORDER BY r.RequestID DESC
    ";

            using SqlCommand cmd =
                new(query, conn);

            cmd.Parameters.AddWithValue(
                "@UserID",
                userId);

            using SqlDataReader reader =
                cmd.ExecuteReader();

            while (reader.Read())
            {
                logs.Add(
                    new ActivityLogModel
                    {
                        RequestID =
                            Convert.ToInt32(
                                reader["RequestID"]),

                        Title =
                            reader["Title"].ToString()!,

                        BorrowDate =
                            Convert.ToDateTime(
                                reader["BorrowDate"]),

                        ReturnDate =
                            Convert.ToDateTime(
                                reader["ReturnDate"]),

                        Status =
                            reader["Status"].ToString()!,

                        SlipNumber =
                            $"SLIP-{reader["RequestID"]}"
                    });
            }

            return logs;
        }
    }
}