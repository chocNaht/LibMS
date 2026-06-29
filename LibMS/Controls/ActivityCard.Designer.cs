namespace LibMS.Controls
{
    partial class ActivityCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSlip = new Label();
            lblStatus = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblBorrowDate = new Label();
            lblReturnDate = new Label();
            btnReturnRequest = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 120);
            lblTitle.Location = new Point(3, 0);
            lblTitle.MaximumSize = new Size(600, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(75, 38);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Title";
            // 
            // lblSlip
            // 
            lblSlip.AutoSize = true;
            lblSlip.Location = new Point(3, 0);
            lblSlip.Name = "lblSlip";
            lblSlip.Size = new Size(41, 25);
            lblSlip.TabIndex = 1;
            lblSlip.Text = "Slip";
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatus.Location = new Point(647, 9);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(120, 40);
            lblStatus.TabIndex = 1;
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.769516F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.230484F));
            tableLayoutPanel1.Controls.Add(lblSlip, 0, 0);
            tableLayoutPanel1.Controls.Add(lblBorrowDate, 0, 1);
            tableLayoutPanel1.Controls.Add(lblReturnDate, 1, 1);
            tableLayoutPanel1.Location = new Point(22, 85);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(538, 75);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // lblBorrowDate
            // 
            lblBorrowDate.AutoSize = true;
            lblBorrowDate.Location = new Point(3, 37);
            lblBorrowDate.Name = "lblBorrowDate";
            lblBorrowDate.Size = new Size(106, 25);
            lblBorrowDate.TabIndex = 3;
            lblBorrowDate.Text = "BorrowDate";
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Location = new Point(260, 37);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(100, 25);
            lblReturnDate.TabIndex = 4;
            lblReturnDate.Text = "ReturnDate";
            // 
            // btnReturnRequest
            // 
            btnReturnRequest.BackColor = Color.RoyalBlue;
            btnReturnRequest.FlatAppearance.BorderSize = 0;
            btnReturnRequest.FlatStyle = FlatStyle.Flat;
            btnReturnRequest.ForeColor = Color.White;
            btnReturnRequest.Location = new Point(566, 101);
            btnReturnRequest.Name = "btnReturnRequest";
            btnReturnRequest.Size = new Size(206, 40);
            btnReturnRequest.TabIndex = 0;
            btnReturnRequest.Text = "Submit Return Request";
            btnReturnRequest.UseVisualStyleBackColor = false;
            btnReturnRequest.Click += btnReturnRequest_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel2.Location = new Point(22, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(538, 80);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // ActivityCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(lblStatus);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnReturnRequest);
            Name = "ActivityCard";
            Size = new Size(800, 180);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSlip;
        private Label lblStatus;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblBorrowDate;
        private Label lblReturnDate;
        private Button btnReturnRequest;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
