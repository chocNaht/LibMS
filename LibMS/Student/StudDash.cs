using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibMS.Controls;
using LibMS.DBData;
using LibMS.Models;
using Microsoft.Data.SqlClient;

namespace LibMS
{
    public partial class StudDash : Form
    {
        private List<ActivityLogModel> _activityLogs = new();
        private readonly List<Panel> mainPanels = new();
        private readonly int _userId;
        private int _editingRequestId;

        public StudDash(int userId)
        {
            InitializeComponent();
            InitializePanels();

            _userId = userId;

            InitializeDashboard();
            LoadBooksToEditCombo();

            txtSearch1.TextChanged += txtSearch1_TextChanged;
        }
        private void InitializeDashboard()
        {
            ShowPanel(dashboardPanel);
            LoadBooks();
        }

        public void UpdateRequest(
    int requestId,
    DateTime borrowDate,
    DateTime returnDate)
        {
            using SqlConnection conn =
                Database.GetConnection();

            conn.Open();

            string query = @"
    UPDATE Request
    SET
        BorrowDate = @BorrowDate,
        ReturnDate = @ReturnDate
    WHERE RequestID = @RequestID";

            using SqlCommand cmd =
                new(query, conn);

            cmd.Parameters.AddWithValue(
                "@RequestID",
                requestId);

            cmd.Parameters.AddWithValue(
                "@BorrowDate",
                borrowDate.Date);

            cmd.Parameters.AddWithValue(
                "@ReturnDate",
                returnDate.Date);

            cmd.ExecuteNonQuery();
        }

        private void LoadApprovedRequests()
        {
            flowApprovedRequests.Controls.Clear();

            BookRepository repo = new();

            var requests =
                repo.GetRequestsByUser(_userId);

            foreach (var request in requests)
            {
                ApprovedRequestCard card = new();

                card.LoadData(
                    request.BookTitle,
                    request.RequestID,
                    request.BorrowDate,
                    request.ReturnDate,
                    request.SlipNumber,
                    request.Status);

                card.EditClicked += (s, e) =>
                {
                    EditRequest(request.RequestID);
                };

                card.CancelClicked += (s, e) =>
                {
                    CancelRequest(request.RequestID);
                };

                flowApprovedRequests.Controls.Add(card);
            }
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

                card.BookSelected += ShowBookDetails;

                flowLayoutPanel1.Controls.Add(card);
            }

            flowLayoutPanel1.ResumeLayout();
        }

        // Method to show a specific panel and hide others
        private void txtSearch1_TextChanged(object? sender, EventArgs e)
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

        private void EditRequest(int requestId)
        {
            BookRequestRepository repo = new();

            BookRequest? request =
                repo.GetRequestById(requestId);

            if (request == null)
                return;

            lblOrigTitle.Text = request.BookTitle;

            lblOrigRequestID.Text = $"Request ID: {request.RequestID:D3}";

            lblOrigBorrowDate.Text = $"Borrow Date: {request.BorrowDate:yyyy-MM-dd}";

            lblOrigReturnDate.Text = $"Return Date: {request.ReturnDate:yyyy-MM-dd}";

            lblOrigStatus.Text = request.Status;

            _editingRequestId =
                requestId;

            cmbEditBook.Text =
                request.BookTitle;

            dtfEditBorrowDate.Value =
                request.BorrowDate;

            dtfEditReturnDate.Value =
                request.ReturnDate;

            ShowPanel(brEditPanel);
        }

        private void CancelRequest(int requestId)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to cancel this request?",
                    "Cancel Request",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            BookRequestRepository repo = new();

            repo.CancelRequest(requestId);

            MessageBox.Show(
                "Request cancelled successfully.");

            LoadApprovedRequests();
        }

        private void LoadBooksToEditCombo()
        {
            BookRepository repo = new();

            cmbEditBook.DataSource =
                repo.GetAllBooks();

            cmbEditBook.DisplayMember =
                "Title";

            cmbEditBook.ValueMember =
                "BookID";
        }

        private void LoadActivityLogs()
        {
            flowActivityLogs.Controls.Clear();

            BookRequestRepository repo = new();

            var logs =
                repo.GetActivityLogs(_userId);

            foreach (var log in logs)
            {
                ActivityCard card = new();

                card.LoadData(
                    log.Title,
                    log.SlipNumber,
                    log.BorrowDate,
                    log.ReturnDate,
                    log.Status);

                card.ReturnRequested +=
                    (s, e) =>
                    {
                        SubmitReturnRequest(
                            log.RequestID);
                    };

                flowActivityLogs.Controls.Add(card);
            }
        }

        private void SubmitReturnRequest(int requestId)
        {
            var repo = new BookRequestRepository();

            bool success =
                repo.SubmitReturnRequest(requestId);

            if (success)
            {
                MessageBox.Show(
                    "Return request submitted successfully.");

                LoadActivityLogs();
                LoadActivitySummary();
            }
            else
            {
                MessageBox.Show(
                    "Failed to submit return request.");
            }
        }

        private void LoadActivitySummary()
        {
            BookRequestRepository repo = new();

            var logs = repo.GetActivityLogs(_userId);

            int borrowedCount =
                logs.Count(x => x.Status == "Borrowed");

            int returnedCount =
                logs.Count(x => x.Status == "Returned");

            lblBorrowedCount.Text =
                borrowedCount.ToString();

            lblReturnedCount.Text =
                returnedCount.ToString();
        }

        private void DisplayActivityLogs(
    List<ActivityLogModel> logs)
        {
            flowActivityLogs.Controls.Clear();

            foreach (var log in logs)
            {
                ActivityCard card = new();

                card.LoadData(
                    log.Title,
                    log.SlipNumber,
                    log.BorrowDate,
                    log.ReturnDate,
                    log.Status);

                card.ReturnRequested +=
                    (s, e) =>
                    {
                        SubmitReturnRequest(
                            log.RequestID);
                    };

                flowActivityLogs.Controls.Add(card);
            }
        }
    }
}