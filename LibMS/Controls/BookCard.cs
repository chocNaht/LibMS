using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LibMS.Models;

namespace LibMS.Controls;

public partial class BookCard : UserControl
{
    private Book? _book;

    public BookCard()
    {
        InitializeComponent();
    }

    public BookCard(Book book)
    {
        InitializeComponent();

        lblTitle.Text = book.Title;
        lblAuthor.Text = $"by {book.Author}";
        lblCategory.Text = $"Category: {book.Category}";
        lblPublisher.Text = $"Publisher: {book.Publisher}";
        lblCopyright.Text = $"Copyright: {book.Copyright.Year}";

        lblStatus.Text =
            book.NumOfCopies > 0
            ? "Available"
            : "Not Available";

        lblStatus.ForeColor =
            book.NumOfCopies > 0
            ? Color.LimeGreen
            : Color.Red;

        lblCopies.Text = $"{book.AvailableCopies} of {book.NumOfCopies} copies";
    }
}
