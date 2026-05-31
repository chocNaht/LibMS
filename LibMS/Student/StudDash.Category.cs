using LibMS.Controls;
using LibMS.Models;

namespace LibMS
{
    public partial class StudDash
    {

        private void btnFic_Click(object sender, System.EventArgs e) { LoadCategory("FICTION"); }
        private void btnSci_Click(object sender, System.EventArgs e) { LoadCategory("SCIENCE"); }
        private void btnHis_Click(object sender, System.EventArgs e) { LoadCategory("HISTORY"); }
        private void btnCaps_Click(object sender, System.EventArgs e) { LoadCategory("CAPSTONE"); }

        // "All" button click event handler to show all books
        private void btnAll_Click(object sender, System.EventArgs e)
        {
            LoadBooks();
        }

        // Loads books of the selected category into the flow layout panel
        private void LoadCategory(string category)
        {
            flowLayoutPanel1.Controls.Clear();

            var books =
                _bookRepo.GetBooksByCategory(category);

            foreach (Book book in books)
            {
                flowLayoutPanel1.Controls.Add(
                    new BookCard(book));
            }
        }
    }
}