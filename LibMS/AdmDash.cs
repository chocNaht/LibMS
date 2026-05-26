using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibMS
{
    public partial class AdmDash : Form
    {
        public AdmDash()
        {
            InitializeComponent();
        }

        private void AdmDash_Load(object sender, EventArgs e)
        {
            HideAllPanels();
            borrowReturnPanel.Visible = true;
            borrowReturnPanel.BringToFront();
            ShowBorrowEntry();
        }
        private void HideAllPanels()
        {
            borrowReturnPanel.Parent = admMainPanel;
            manageBooksPanel.Parent = admMainPanel;
            manageUsersPanel.Parent = admMainPanel;
            EditBookPanel.Parent = admMainPanel;
            addBookPanel.Parent = admMainPanel;
            lblAddUser.Parent = admMainPanel;
            EditUserPanel.Parent = admMainPanel;

            borrowReturnPanel.Visible = false;
            manageBooksPanel.Visible = false;
            manageUsersPanel.Visible = false;
            EditBookPanel.Visible = false;
            addBookPanel.Visible = false;
            lblAddUser.Visible = false;
            EditUserPanel.Visible = false;

        }

        private void btnBorrowReturn_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            borrowReturnPanel.Visible = true;
            borrowReturnPanel.BringToFront();
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            manageBooksPanel.Visible = true;
            manageBooksPanel.BringToFront();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            manageUsersPanel.Visible = true;
            manageUsersPanel.BringToFront();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                ("Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                WelcomeLogin login = new WelcomeLogin();
                login.Show();

                this.Hide();
            }
        }

        private void BrHideAllPanels()
        {
            borrowEntryPanel.Parent = brMainPanel;
            bookRequestsPanel.Parent = brMainPanel;
            returnRequestsPanel.Parent = brMainPanel;

            borrowEntryPanel.Visible = false;
            bookRequestsPanel.Visible = false;
            returnRequestsPanel.Visible = false;

            btnBorrowEntry.BackColor = Color.LightGray;
            btnBookRequests.BackColor = Color.LightGray;
            btnReturnRequests.BackColor = Color.LightGray;
        }

        private void ShowBorrowEntry()
        {
            BrHideAllPanels();

            borrowEntryPanel.Visible = true;
            borrowEntryPanel.BringToFront();

            btnBorrowEntry.BackColor = Color.Gold;
        }

        private void ShowBookRequests()
        {
            BrHideAllPanels();

            bookRequestsPanel.Visible = true;
            bookRequestsPanel.BringToFront();

            btnBookRequests.BackColor = Color.Gold;
        }

        private void ShowReturnRequests()
        {
            BrHideAllPanels();

            returnRequestsPanel.Visible = true;
            returnRequestsPanel.BringToFront();

            btnReturnRequests.BackColor = Color.Gold;
        }

        private void btnBorrowEntry_Click(object sender, EventArgs e)
        {
            ShowBorrowEntry();
        }

        private void btnBookRequests_Click(object sender, EventArgs e)
        {
            ShowBookRequests();
        }

        private void btnReturnRequests_Click(object sender, EventArgs e)
        {
            ShowReturnRequests();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            EditBookPanel.Visible = true;
            EditBookPanel.BringToFront();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            addBookPanel.Visible = true;
            addBookPanel.BringToFront();
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            manageBooksPanel.Visible = true;
            manageBooksPanel.BringToFront();
        }

        private void btnUpdBook_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            manageBooksPanel.Visible = true;
            manageBooksPanel.BringToFront();
        }

        private void btnCanBook_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            manageBooksPanel.Visible = true;
            manageBooksPanel.BringToFront();
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            manageBooksPanel.Visible = true;
            manageBooksPanel.BringToFront();
        }

        private void btnAddBook1_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            manageBooksPanel.Visible = true;
            manageBooksPanel.BringToFront();
        }

        private void btnEdit2_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            EditUserPanel.Visible = true;
            EditUserPanel.BringToFront();
        }

        private void btnAddBook2_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            EditUserPanel.Visible = true;
            EditUserPanel.BringToFront();
        }

        private void btnAddUser1_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            manageUsersPanel.Visible = true;
            manageUsersPanel.BringToFront();
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            manageUsersPanel.Visible = true;
            manageUsersPanel.BringToFront();
        }

        private void btnCan2_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            manageUsersPanel.Visible = true;
            manageUsersPanel.BringToFront();
        }

        private void btnUpdUser_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            manageUsersPanel.Visible = true;
            manageUsersPanel.BringToFront();
        }

        private void btnCan3_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            manageUsersPanel.Visible = true;
            manageUsersPanel.BringToFront();
        }

        private void btnBack4_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            manageUsersPanel.Visible = true;
            manageUsersPanel.BringToFront();
        }
    }
}

