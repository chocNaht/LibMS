namespace LibMS.Controls
{
    partial class ApprovedRequestCard
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblBookTitle;
        private Label lblRequestID;
        private Label lblBorrowDate;
        private Label lblReturnDate;
        private Label lblSlipNumber;
        private Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblBookTitle = new Label();
            lblRequestID = new Label();
            lblBorrowDate = new Label();
            lblReturnDate = new Label();
            lblSlipNumber = new Label();
            lblStatus = new Label();
            btnCancel = new Button();
            btnEdit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblBookTitle
            // 
            lblBookTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBookTitle.ForeColor = Color.MediumBlue;
            lblBookTitle.Location = new Point(3, 0);
            lblBookTitle.MaximumSize = new Size(520, 0);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(517, 60);
            lblBookTitle.TabIndex = 0;
            lblBookTitle.Text = "Book Title";
            // 
            // lblRequestID
            // 
            lblRequestID.AutoSize = true;
            lblRequestID.Location = new Point(3, 65);
            lblRequestID.Name = "lblRequestID";
            lblRequestID.Size = new Size(98, 25);
            lblRequestID.TabIndex = 1;
            lblRequestID.Text = "Request ID";
            // 
            // lblBorrowDate
            // 
            lblBorrowDate.AutoSize = true;
            lblBorrowDate.Location = new Point(3, 100);
            lblBorrowDate.Name = "lblBorrowDate";
            lblBorrowDate.Size = new Size(111, 25);
            lblBorrowDate.TabIndex = 2;
            lblBorrowDate.Text = "Borrow Date";
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Location = new Point(3, 135);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(105, 25);
            lblReturnDate.TabIndex = 3;
            lblReturnDate.Text = "Return Date";
            // 
            // lblSlipNumber
            // 
            lblSlipNumber.AutoSize = true;
            lblSlipNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSlipNumber.ForeColor = Color.DarkGreen;
            lblSlipNumber.Location = new Point(3, 170);
            lblSlipNumber.Name = "lblSlipNumber";
            lblSlipNumber.Size = new Size(117, 25);
            lblSlipNumber.TabIndex = 4;
            lblSlipNumber.Text = "Slip Number";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Honeydew;
            lblStatus.BorderStyle = BorderStyle.FixedSingle;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.Green;
            lblStatus.Location = new Point(557, 20);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(110, 27);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "APPROVED";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(741, 20);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(45, 45);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "✕";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.White;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEdit.Location = new Point(690, 20);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(45, 45);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "✎";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblBookTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(lblRequestID, 0, 1);
            tableLayoutPanel1.Controls.Add(lblBorrowDate, 0, 2);
            tableLayoutPanel1.Controls.Add(lblSlipNumber, 0, 4);
            tableLayoutPanel1.Controls.Add(lblReturnDate, 0, 3);
            tableLayoutPanel1.Location = new Point(19, 20);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(523, 206);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // ApprovedRequestCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnEdit);
            Controls.Add(btnCancel);
            Controls.Add(lblStatus);
            Name = "ApprovedRequestCard";
            Size = new Size(800, 240);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnCancel;
        private Button btnEdit;
        private TableLayoutPanel tableLayoutPanel1;
    }
}