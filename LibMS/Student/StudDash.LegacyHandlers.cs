using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibMS
{
    public partial class StudDash
    {
        private void button1_Click(object sender, EventArgs e)
            => btnAll_Click(sender, e);

        private void btnBack1_Click(object sender, EventArgs e)
            => GoHome();

        private void btnBack4_Click(object sender, EventArgs e)
            => ShowPanel(brpanel);

        private void btnBackCat1_Click(object sender, EventArgs e)
            => GoHome();

        private void btnBackCat3_Click(object sender, EventArgs e)
            => ShowPanel(borReqPanel);

        private void btnApproved_Click(object sender, EventArgs e)
            => ShowPanel(dashboardPanel);

        // View Book Request
        private void btnViewBookReq_Click(object sender, EventArgs e)
        {
            ShowPanel(borReqPanel);

            approvedPanel.Visible = true;
            approvedPanel.BringToFront();

            LoadApprovedRequests();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowPanel(dashboardPanel);
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
        }

        private void txtBorDate_TextChanged(object sender, EventArgs e)
        {
        }

        private void dashboardPanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}