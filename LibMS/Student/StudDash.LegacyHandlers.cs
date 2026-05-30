using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibMS
{
    public partial class StudDash
    {
        private void button6_Click(object sender, EventArgs e)
            => btnSelect_Click(sender, e);

        private void btnSelect1_Click(object sender, EventArgs e)
            => btnSelect_Click(sender, e);

        private void btnSelect2_Click(object sender, EventArgs e)
            => btnSelect_Click(sender, e);

        private void btnSelect4_Click(object sender, EventArgs e)
            => btnSelect_Click(sender, e);

        private void button1_Click(object sender, EventArgs e)
            => btnAll_Click(sender, e);

        private void btnBack1_Click(object sender, EventArgs e)
            => GoHome();

        private void btnBack4_Click(object sender, EventArgs e)
            => ShowPanel(brpanel);

        private void btnBackCat1_Click(object sender, EventArgs e)
            => ShowPanel(dashboardPanel);

        private void btnBackCat3_Click(object sender, EventArgs e)
            => ShowPanel(borReqPanel);

        private void btnApproved_Click(object sender, EventArgs e)
            => ShowPanel(borReqPanel);

        private void btnViewBookReq_Click(object sender, EventArgs e)
        {
            ShowPanel(bookDetPanel);
        }

        private void btnCan1_Click(object sender, EventArgs e)
        {
            ShowPanel(brpanel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
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