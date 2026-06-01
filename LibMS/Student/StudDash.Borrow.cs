using LibMS.Models;

namespace LibMS
{
    public partial class StudDash
    {
        private Book? _selectedBook;

        // Show book details in the borrow panel
        private void ShowBookDetails(Book book)
        {
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

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            if (_selectedBook == null)
                return;

            ShowPanel(reqSucPanel);

            lblReqBook.Text = $"Book: {_selectedBook.Title}";

            lblReqAuthor.Text = $"Author: {_selectedBook.Author}";

            lblReqBorrowDate.Text = $"Borrow Date: {dtpBorrowDate.Value:yyyy-MM-dd}";

            lblReqReturnDate.Text = $"Return Date: {dtpReturnDate.Value:yyyy-MM-dd}";

            lblReqStatus.Text = "Status: Pending Approval";

            Random random = new();

            lblRequestID.Text =
                random.Next(100, 999)
                .ToString();
        }

        private void btnEdit1_Click(
            object sender,
            EventArgs e)
        {
            ShowPanel(borReqPanel);

            panel6.Visible = false;
            approvedPanel.Visible = false;
            brEditPanel.Visible = true;
        }

        private void btnUpdReq1_Click(
            object sender,
            EventArgs e)
        {
            ShowPanel(reqSucPanel);
        }
    }
}