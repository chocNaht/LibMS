using System.Windows.Forms;
using LibMS.DBData;

namespace LibMS
{
    public partial class StudDash
    {
        private void DeletePanel(Panel p)
        {
            var result = MessageBox.Show("Delete request?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                p.Visible = false;
        }

        private void btnDelete1_Click(object sender, System.EventArgs e)
        {
            DeletePanel(detBPanel);
        }

        private void btnDelete2_Click(object sender, System.EventArgs e)
        {
            DialogResult result =
        MessageBox.Show(
            "Are you sure you want to delete this request?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            BookRequestRepository repo = new();

            repo.CancelRequest(_editingRequestId);

            MessageBox.Show(
                "Request deleted successfully.");

            ShowBookRequestsPage();
        }

        private void ShowBookRequestsPage()
        {
            ShowPanel(approvedPanel);

            approvedPanel.Visible = true;
            approvedPanel.BringToFront();

            LoadApprovedRequests();
        }

        private void GoHome()
        {
            ShowPanel(dashboardPanel);
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            GoHome();
        }

        private void btnLogOut1_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Logout?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new WelcomeLogin().Show();
                this.Hide();
            }
        }
    }
}