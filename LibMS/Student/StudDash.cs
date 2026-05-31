using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibMS.Controls;
using LibMS.DBData;
using LibMS.Models;

namespace LibMS
{
    public partial class StudDash : Form
    {
        private readonly List<Panel> mainPanels = new();
        private readonly int _userId;

        public StudDash(int userId)
        {
            InitializeComponent();
            _userId = userId;
            StudDash_Load(this, EventArgs.Empty);
            txtSearch1.TextChanged += txtSearch1_TextChanged;
        }

        private void StudDash_Load(object sender, EventArgs e)
        {
            ShowPanel(dashboardPanel);
            LoadBooks();
        }

        private readonly BookRepository _bookRepo = new();

        // Loads all books into the flow layout panel as BookCard controls
        private void LoadBooks()
        {
            flowLayoutPanel1.SuspendLayout();

            flowLayoutPanel1.Controls.Clear();

            List<Book> books =
                _bookRepo.GetAllBooks();

            foreach (Book book in books)
            {
                BookCard card = new(book);

                flowLayoutPanel1.Controls.Add(card);
            }

            flowLayoutPanel1.ResumeLayout();
        }

        // Method to show a specific panel and hide others
        private void txtSearch1_TextChanged(object? sender,EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            var books =
                _bookRepo.SearchBooks(
                    txtSearch1.Text.Trim());

            foreach (var book in books)
            {
                flowLayoutPanel1.Controls.Add(new BookCard(book));
            }
        }
    }
}