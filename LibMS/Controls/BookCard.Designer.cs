namespace LibMS.Controls
{
    partial class BookCard
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox picCover;

        private TableLayoutPanel tblInfo;

        private Label lblTitle;
        private Label lblAuthor;
        private Label lblCategory;
        private Label lblPublisher;
        private Label lblCopyright;
        private Label lblStatus;
        private Label lblCopies;

        private Button btnSelect;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            picCover = new PictureBox();

            tblInfo = new TableLayoutPanel();

            lblTitle = new Label();
            lblAuthor = new Label();
            lblCategory = new Label();
            lblPublisher = new Label();
            lblCopyright = new Label();
            lblStatus = new Label();
            lblCopies = new Label();

            btnSelect = new Button();

            ((System.ComponentModel.ISupportInitialize)picCover).BeginInit();

            SuspendLayout();

            // ======================
            // CARD
            // ======================

            BackColor = Color.WhiteSmoke;
            BorderStyle = BorderStyle.FixedSingle;
            Size = new Size(400, 250);
            Margin = new Padding(10);

            // ======================
            // COVER
            // ======================

            picCover.Location = new Point(15, 15);
            picCover.Size = new Size(100, 140);
            picCover.SizeMode = PictureBoxSizeMode.Zoom;
            picCover.BorderStyle = BorderStyle.FixedSingle;

            // ======================
            // TABLE
            // ======================

            tblInfo.Location = new Point(130, 15);
            tblInfo.Size = new Size(250, 170);

            tblInfo.ColumnCount = 1;
            tblInfo.RowCount = 7;

            tblInfo.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100));

            tblInfo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // ======================
            // TITLE
            // ======================

            lblTitle.Font = new Font(
                "Segoe UI",
                13F,
                FontStyle.Bold);

            lblTitle.AutoSize = true;

            lblTitle.MaximumSize = new Size(240, 0);

            // ======================
            // AUTHOR
            // ======================

            lblAuthor.Font = new Font(
                "Segoe UI",
                10F);

            lblAuthor.ForeColor = Color.DimGray;

            lblAuthor.AutoSize = true;

            lblAuthor.MaximumSize = new Size(240, 0);

            // ======================
            // CATEGORY
            // ======================

            lblCategory.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Bold);

            lblCategory.ForeColor = Color.RoyalBlue;

            lblCategory.AutoSize = true;

            lblCategory.MaximumSize = new Size(240, 0);

            // ======================
            // PUBLISHER
            // ======================

            lblPublisher.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Bold);

            lblPublisher.ForeColor = Color.RoyalBlue;

            lblPublisher.AutoSize = true;

            lblPublisher.MaximumSize = new Size(240, 0);

            // ======================
            // COPYRIGHT
            // ======================

            lblCopyright.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Bold);

            lblCopyright.ForeColor = Color.RoyalBlue;

            lblCopyright.AutoSize = true;

            // ======================
            // STATUS
            // ======================

            lblStatus.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold);

            lblStatus.AutoSize = true;

            // ======================
            // COPIES
            // ======================

            lblCopies.Font = new Font(
                "Segoe UI",
                9F);

            lblCopies.ForeColor = Color.DimGray;

            lblCopies.AutoSize = true;

            // ======================
            // BUTTON
            // ======================

            btnSelect.BackColor = Color.Gold;

            btnSelect.FlatStyle = FlatStyle.Flat;

            btnSelect.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Bold);

            btnSelect.ForeColor = Color.Navy;

            btnSelect.Location = new Point(15, 205);

            btnSelect.Size = new Size(370, 35);

            btnSelect.Text = "Select";

            btnSelect.UseVisualStyleBackColor = false;

            // ======================
            // ADD LABELS TO TABLE
            // ======================

            tblInfo.Controls.Add(lblTitle, 0, 0);
            tblInfo.Controls.Add(lblAuthor, 0, 1);
            tblInfo.Controls.Add(lblCategory, 0, 2);
            tblInfo.Controls.Add(lblPublisher, 0, 3);
            tblInfo.Controls.Add(lblCopyright, 0, 4);
            tblInfo.Controls.Add(lblStatus, 0, 5);
            tblInfo.Controls.Add(lblCopies, 0, 6);

            // ======================
            // ADD CONTROLS
            // ======================

            Controls.Add(picCover);
            Controls.Add(tblInfo);
            Controls.Add(btnSelect);

            ((System.ComponentModel.ISupportInitialize)picCover).EndInit();

            ResumeLayout(false);
        }
    }
}