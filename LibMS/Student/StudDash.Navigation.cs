using System.Drawing;
using System.Windows.Forms;

namespace LibMS
{
    public partial class StudDash
    {
        private void SetActive(Button active, params Button[] others)
        {
            active.BackColor = Color.Gold;
            active.ForeColor = Color.Black;

            foreach (var btn in others)
            {
                btn.BackColor = Color.RoyalBlue;
                btn.ForeColor = Color.White;
            }
        }

        private void ShowPanel(Panel target)
        {
            foreach (var panel in mainPanels)
                panel.Visible = false;

            target.Visible = true;
            target.BringToFront();
        }

        // Initialize the list of main panels and set their properties
        private void InitializePanels()
        {
            mainPanels.Clear();

            mainPanels.AddRange(new[]
            {
                dashboardPanel,
                brpanel,
                borrowPanel,
                borReqPanel,
                alpanel,
                bookDetPanel,
                reqSucPanel,
                approvedPanel,
                brEditPanel
            });
            foreach (var panel in mainPanels)
            {
                panel.Dock = DockStyle.Fill;
                panel.Parent = mainPanel;
                panel.Visible = false;
            }
        }

        private void btnStudDash_Click(object sender, System.EventArgs e)
        {
            SetActive(btnStudDash, btnStudBr, btnStudActLog);
            ShowPanel(dashboardPanel);
        }

        // Book Request Panel
        private void btnStudBr_Click(object sender, EventArgs e)
        {
            SetActive(btnStudBr, btnStudDash, btnStudActLog);

            ShowPanel(borReqPanel);

            approvedPanel.Visible = true;
            approvedPanel.BringToFront();

            LoadApprovedRequests();
        }

        private void btnStudActLog_Click(object sender, EventArgs e)
        {
            SetActive(btnStudActLog, btnStudDash, btnStudBr);

            ShowPanel(alpanel);

            LoadActivityLogs();
            LoadActivitySummary();

            flowActivityLogs.BringToFront();
        }
    }
}