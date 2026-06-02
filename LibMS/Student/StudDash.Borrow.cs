using LibMS.DBData;
using LibMS.Models;

namespace LibMS
{
    public partial class StudDash
    {
        private Book? _selectedBook;

        // Show book details in the borrow panel
        private void ShowBookDetails(Book book)
        {
            _selectedBook = book;
            ShowPanel(borrowPanel);

            lblBorrowTitle.Text = book.Title;
            lblBorrowAuthor.Text = book.Author;

            lblBorrowID.Text = $"Book ID: {book.BookID:D3}";
            lblBorrowCategory.Text = $"Category: {book.Category}";
            lblBorrowPublisher.Text =$"Publisher: {book.Publisher}";
            lblBorrowCopyright.Text =$"Copyright: {book.Copyright.Year}";
            lblBorrowCopies.Text = $"{book.AvailableCopies} of {book.NumOfCopies} copies";

            lblBorrowStatus.Text = book.AvailableCopies > 0 ? "AVAILABLE" : "NOT AVAILABLE";

            lblBorrowStatus.ForeColor =
                book.AvailableCopies > 0
                ? Color.LimeGreen
                : Color.Red;

            LoadBorrowCover(book);

            dtpBorrowDate.Value =
                DateTime.Today;

            dtpReturnDate.Value =
                DateTime.Today.AddDays(7);

            btnBorrowBook.Enabled =
                book.AvailableCopies > 0;
        }

        // Load book cover image in the borrow panel
        private void LoadBorrowCover(Book book)
        {
            picBorrowCover.Image = null;

            if (string.IsNullOrWhiteSpace(book.BookCover))
                return;

            string imagePath =
                Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    book.BookCover);

            if (File.Exists(imagePath))
            {
                picBorrowCover.Image =
                    Image.FromFile(imagePath);

                picBorrowCover.SizeMode =
                    PictureBoxSizeMode.Zoom;
            }
        }

        // Handle borrow button click
        private void btnBorrowBook_Click(object sender,EventArgs e)
        {
            if (_selectedBook == null)
                return;

            BookRepository repo = new();

            int requestId =
                repo.CreateRequest(
                    _userId,
                    _selectedBook.BookID,
                    dtpBorrowDate.Value,
                    dtpReturnDate.Value);

            lblRequestID.Text =
                requestId.ToString();

            ShowPanel(reqSucPanel);

            panel6.Visible = true;
            panel6.BringToFront();

            lblReqBook.Text =
                $"Book: {_selectedBook.Title}";

            lblReqAuthor.Text =
                $"Author: {_selectedBook.Author}";

            lblReqBorrowDate.Text =
                $"Borrow Date: {dtpBorrowDate.Value:yyyy-MM-dd}";

            lblReqReturnDate.Text =
                $"Return Date: {dtpReturnDate.Value:yyyy-MM-dd}";

            lblReqStatus.Text =
                "Status: Pending Approval";

            lblReqStatus.ForeColor =
                Color.IndianRed;
        }

        private void btnEdit1_Click(
            object sender,
            EventArgs e)
        {
            ShowPanel(reqSucPanel);

            panel6.Visible = false;
            approvedPanel.Visible = false;
            brEditPanel.Visible = true;
        }


        private void btnUpdReq1_Click(object sender, EventArgs e)
{
    BookRequestRepository repo = new();

    int bookId =
        Convert.ToInt32(
            cmbEditBook.SelectedValue);

    bool success =
        repo.UpdateRequest(
            _editingRequestId,
            bookId,
            dtfEditBorrowDate.Value,
            dtfEditReturnDate.Value);

    if (success)
    {
        MessageBox.Show(
            "Request updated.");

        ShowPanel(approvedPanel);

        LoadApprovedRequests();
    }
}

        private void btnCan1_Click(
    object sender,
    EventArgs e)
        {
            ShowPanel(approvedPanel);
        }
    }
}