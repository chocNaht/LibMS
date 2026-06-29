using LibMS.Models;
using Microsoft.Data.SqlClient;

namespace LibMS.DBData;

public class BookRepository
{
    // Method to retrieve all books from the database
    public List<Book> GetAllBooks()
    {
        List<Book> books = [];

        using SqlConnection conn =
            Database.GetConnection();

        conn.Open();

        string query = "SELECT * FROM Books";

        using SqlCommand cmd =
            new(query, conn);

        using SqlDataReader reader =
            cmd.ExecuteReader();

        while (reader.Read())
        {
            books.Add(MapBook(reader));
        }


        return books;
    }

    // Helper method to map a SqlDataReader row to a Book object
    private static Book MapBook(SqlDataReader reader)
    {
        return new Book
        {
            BookID = Convert.ToInt32(reader["BookID"]),
            Title = reader["Title"].ToString() ?? "",
            Author = reader["Author"].ToString() ?? "",
            Copyright = Convert.ToDateTime(reader["Copyright"]),
            Publisher = reader["Publisher"].ToString() ?? "",
            Category = reader["Category"].ToString() ?? "",
            BookCover = reader["BookCover"].ToString() ?? "",
            NumOfCopies = Convert.ToInt32(reader["NumOfCopies"]),
            AvailableCopies =Convert.ToInt32(reader["AvailableCopies"])
        };
    }

    // Method to search for books by title or author
    public List<Book> SearchBooks(string keyword)
    {
        List<Book> books = [];

        using SqlConnection conn = Database.GetConnection();

        conn.Open();

        string query = @"
        SELECT *
        FROM Books
        WHERE Title LIKE @Search
           OR Author LIKE @Search";

        using SqlCommand cmd = new(query, conn);

        cmd.Parameters.AddWithValue(
            "@Search",
            $"%{keyword}%");

        using SqlDataReader reader =
            cmd.ExecuteReader();

        while (reader.Read())
        {
            books.Add(MapBook(reader));
        }

        return books;
    }

    // Method to filter books by category
    public List<Book> GetBooksByCategory(
    string category)
    {
        List<Book> books = [];

        using SqlConnection conn =
            Database.GetConnection();

        conn.Open();

        string query = @"
        SELECT *
        FROM Books
        WHERE Category = @Category";

        using SqlCommand cmd =
            new(query, conn);

        cmd.Parameters.AddWithValue(
            "@Category",
            category);

        using SqlDataReader reader =
            cmd.ExecuteReader();

        while (reader.Read())
        {
            books.Add(MapBook(reader));
        }

        return books;
    }

    // Method to get a book by its ID
    public Book? GetBookById(int bookId)
    {
        using SqlConnection conn =
            Database.GetConnection();

        MessageBox.Show(
    Database.GetConnection().ConnectionString);
        conn.Open();

        string query = @"
        SELECT *
        FROM Books
        WHERE BookID = @BookID";

        using SqlCommand cmd =
            new(query, conn);

        cmd.Parameters.AddWithValue(
            "@BookID",
            bookId);

        using SqlDataReader reader =
            cmd.ExecuteReader();

        if (reader.Read())
        {
            return MapBook(reader);
        }

        return null;
    }

    // Method to create a new book request
    public int CreateRequest(
    int userId,
    int bookId,
    DateTime borrowDate,
    DateTime returnDate)
    {
        using SqlConnection conn =
            Database.GetConnection();

        conn.Open();

        string query = @"
    INSERT INTO Request
    (
        UserID,
        BookID,
        BorrowDate,
        ReturnDate,
        Status
    )
    OUTPUT INSERTED.RequestID
    VALUES
    (
        @UserID,
        @BookID,
        @BorrowDate,
        @ReturnDate,
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

        cmd.Parameters.AddWithValue(
            "@BorrowDate",
            borrowDate.Date);

        cmd.Parameters.AddWithValue(
            "@ReturnDate",
            returnDate.Date);

        return Convert.ToInt32(
            cmd.ExecuteScalar());
    }

    // Method to retrieve all book requests made by a specific user
    public List<BookRequest> GetRequestsByUser(
    int userId)
    {
        List<BookRequest> requests = new();

        using SqlConnection conn =
            Database.GetConnection();

        conn.Open();

        string query = @"
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
    ORDER BY r.RequestID DESC";

        using SqlCommand cmd =
            new(query, conn);

        cmd.Parameters.AddWithValue(
            "@UserID",
            userId);

        using SqlDataReader reader =
            cmd.ExecuteReader();

        while (reader.Read())
        {
            requests.Add( new BookRequest
            {
                RequestID =
                    Convert.ToInt32(
                        reader["RequestID"]),

                BookTitle =
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

        return requests;
    }
}