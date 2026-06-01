using LibMS.Models;
using System.Drawing;
using System.Windows.Forms;

namespace LibMS.Controls;

public partial class BookCard : UserControl
{
    public event Action<Book>? BookSelected;

    private Book? _book;

    public BookCard()
    {
        InitializeComponent();
    }

    public BookCard(Book book)
    {
        InitializeComponent();

        _book = book;

        if (!string.IsNullOrWhiteSpace(book.BookCover))
        {
            string imagePath =
                Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    book.BookCover);

            if (File.Exists(imagePath))
            {
                picCover.Image =
                    Image.FromFile(imagePath);

                picCover.SizeMode =
                    PictureBoxSizeMode.Zoom;
            }
        }

        lblTitle.Text = book.Title;
        lblAuthor.Text = $"by {book.Author}";
        lblCategory.Text = $"Category: {book.Category}";
        lblPublisher.Text = $"Publisher: {book.Publisher}";
        lblCopyright.Text = $"Copyright: {book.Copyright.Year}";

        lblStatus.Text =
            book.AvailableCopies > 0
            ? "Available"
            : "Not Available";

        lblStatus.ForeColor =
            book.AvailableCopies > 0
            ? Color.LimeGreen
            : Color.Red;

        lblCopies.Text =
            $"{book.AvailableCopies} of {book.NumOfCopies} copies";
    }

    private void btnSelect_Click(
        object sender,
        EventArgs e)
    {
        if (_book != null)
        {
            BookSelected?.Invoke(_book);
        }
    }
}