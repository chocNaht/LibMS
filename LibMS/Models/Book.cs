namespace LibMS.Models;

public class Book
{
    public int BookID { get; set; }

    public string Title { get; set; } = "";

    public string Author { get; set; } = "";

    public DateTime Copyright { get; set; }

    public string Publisher { get; set; } = "";

    public string Category { get; set; } = "";

    public string BookCover { get; set; } = "";

    public int NumOfCopies { get; set; }

    public int AvailableCopies { get; set; }
}