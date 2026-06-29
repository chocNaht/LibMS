using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibMS.Controls
{
    public partial class ApprovedRequestCard : UserControl
    {
        public event EventHandler? EditClicked;
        public event EventHandler? CancelClicked;

        public int RequestID { get; private set; }

        public ApprovedRequestCard()
        {
            InitializeComponent();

            btnEdit.Click += (s, e) =>
            {
                EditClicked?.Invoke(this, EventArgs.Empty);
            };

            btnCancel.Click += (s, e) =>
            {
                CancelClicked?.Invoke(this, EventArgs.Empty);
            };

        }

        public void LoadData(
            string title,
            int requestId,
            DateTime borrowDate,
            DateTime returnDate,
            string slipNumber,
            string status)
        {

            RequestID = requestId;
            lblBookTitle.Text = title;

            lblRequestID.Text =
                $"Request ID: {requestId}";

            lblBorrowDate.Text =
                $"Borrow Date: {borrowDate:yyyy-MM-dd}";

            lblReturnDate.Text =
                $"Return Date: {returnDate:yyyy-MM-dd}";

            lblSlipNumber.Text = $"Slip Number: {slipNumber}";

            lblStatus.Text =
                status.ToUpper();
            
            switch (status.ToUpper())
            {
                case "PENDING":

                    lblStatus.BackColor =
                        Color.Gold;

                    lblStatus.ForeColor =
                        Color.Black;

                    break;

                case "APPROVED":

                    lblStatus.BackColor =
                        Color.Honeydew;

                    lblStatus.ForeColor =
                        Color.DarkGreen;

                    break;

                case "RETURNED":

                    lblStatus.BackColor =
                        Color.Gainsboro;

                    lblStatus.ForeColor =
                        Color.Black;

                    break;

                default:

                    lblStatus.BackColor =
                        Color.LightGray;

                    lblStatus.ForeColor =
                        Color.Black;

                    break;
            }
        }
    }
}