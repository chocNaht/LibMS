using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace LibMS.Controls
{
    public partial class ActivityCard : UserControl
    {
        public event EventHandler? ReturnRequested;

        public ActivityCard()
        {
            InitializeComponent();

            BorderStyle = BorderStyle.FixedSingle;

            Width = 950;
            Height = 150;

            Margin = new Padding(10);
        }

        public void LoadData(
    string title,
    string slipNumber,
    DateTime borrowDate,
    DateTime returnDate,
    string status)
        {
            lblTitle.Text = title;

            lblSlip.Text =
                $"Slip: {slipNumber}";

            lblBorrowDate.Text =
                $"Borrow: {borrowDate:yyyy-MM-dd}";

            lblReturnDate.Text =
                $"Return: {returnDate:yyyy-MM-dd}";

            lblStatus.Text = status;

            if (status == "Borrowed")
            {
                lblStatus.BackColor = Color.Gold;
                lblStatus.ForeColor = Color.Black;

                btnReturnRequest.Visible = true;
            }
            else if (status == "Returned")
            {
                lblStatus.BackColor = Color.LimeGreen;
                lblStatus.ForeColor = Color.White;

                btnReturnRequest.Visible = false;
            }
            else if (status == "Return Pending")
            {
                lblStatus.BackColor = Color.Orange;
                lblStatus.ForeColor = Color.White;

                btnReturnRequest.Visible = false;
            }
        }

        private void btnReturnRequest_Click(
            object sender,
            EventArgs e)
        {
            ReturnRequested?.Invoke(
                this,
                EventArgs.Empty);
        }
    }
}