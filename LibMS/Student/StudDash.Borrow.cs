using System.Windows.Forms;
using LibMS.Controls;
using LibMS.DBData;
using LibMS.Models;

namespace LibMS
{
    public partial class StudDash
    {
        private void btnSelect_Click(object sender, System.EventArgs e)
        {
            ShowPanel(borrowPanel);
        }

        private void btnBorBook_Click(object sender, System.EventArgs e)
        {
            ShowPanel(borReqPanel);

            panel6.Visible = true;
            approvedPanel.Visible = false;
            brEditPanel.Visible = false;
        }

        private void btnEdit1_Click(object sender, System.EventArgs e)
        {
            ShowPanel(borReqPanel);

            panel6.Visible = false;
            approvedPanel.Visible = false;
            brEditPanel.Visible = true;
        }

        private void btnUpdReq1_Click(object sender, System.EventArgs e)
        {
            ShowPanel(reqSucPanel);
        }
    }
}