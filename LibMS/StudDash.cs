using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibMS
{
    public partial class StudDash : Form
    {
        public StudDash()
        {
            InitializeComponent();
        }

        private void StudDash_Load(object sender, EventArgs e)
        {

            dashboardPanel.Dock = DockStyle.Fill;
            brpanel.Dock = DockStyle.Fill;
            borrowPanel.Dock = DockStyle.Fill;
            borReqPanel.Dock = DockStyle.Fill;
            alpanel.Dock = DockStyle.Fill;
            brEditPanel.Dock = DockStyle.Fill;
            bookDetPanel.Dock = DockStyle.Fill;
            reqSucPanel.Dock = DockStyle.Fill;

            brEditPanel.Parent = mainPanel;

            dashboardPanel.Visible = true;

            brpanel.Visible = false;
            borrowPanel.Visible = false;
            borReqPanel.Visible = false;
            alpanel.Visible = false;
            brEditPanel.Visible = false;
            bookDetPanel.Visible = false;
            reqSucPanel.Visible = false;

            detBPanel.Visible = true;

            editReqPanel.Visible = true;
            origBookPanel.Visible = true;

            subRetReqPanel.Visible = true;
            subRetPanel.Visible = true;
            borBookPanel1.Visible = true;

            brEditPanel.BringToFront();
            dashboardPanel.BringToFront();

        }

        private void HideAllPanels()
        {
            dashboardPanel.Visible = false;
            brpanel.Visible = false;
            borrowPanel.Visible = false;
            borReqPanel.Visible = false;
            alpanel.Visible = false;

            brEditPanel.Visible = false;
            bookDetPanel.Visible = false;
            reqSucPanel.Visible = false;

            dashboardPanel.Parent = mainPanel;
            brpanel.Parent = mainPanel;
            borrowPanel.Parent = mainPanel;
            borReqPanel.Parent = mainPanel;
            alpanel.Parent = mainPanel;
            brEditPanel.Parent = mainPanel;
            bookDetPanel.Parent = mainPanel;
            reqSucPanel.Parent = mainPanel;

        }

        private void btnStudDash_Click(object sender, EventArgs e)
        {
            btnStudDash.BackColor = Color.Gold;
            btnStudBr.BackColor = Color.RoyalBlue;
            btnStudActLog.BackColor = Color.RoyalBlue;

            btnStudDash.ForeColor = Color.Black;
            btnStudBr.ForeColor = Color.White;
            btnStudActLog.ForeColor = Color.White;

            HideAllPanels();

            dashboardPanel.Visible = true;
        }

        private void btnStudBr_Click(object sender, EventArgs e)
        {
            btnStudDash.BackColor = Color.RoyalBlue;
            btnStudBr.BackColor = Color.Gold;
            btnStudActLog.BackColor = Color.RoyalBlue;

            btnStudDash.ForeColor = Color.White;
            btnStudBr.ForeColor = Color.Black;
            btnStudActLog.ForeColor = Color.White;

            HideAllPanels();

            brpanel.Visible = true;
            brpanel.BringToFront();

            detBPanel.Visible = true;

        }

        private void btnStudActLog_Click(object sender, EventArgs e)
        {
            btnStudDash.BackColor = Color.RoyalBlue;
            btnStudBr.BackColor = Color.RoyalBlue;
            btnStudActLog.BackColor = Color.Gold;

            btnStudDash.ForeColor = Color.White;
            btnStudBr.ForeColor = Color.White;
            btnStudActLog.ForeColor = Color.Black;

            HideAllPanels();

            alpanel.Visible = true;
        }

        private void btnSelect1_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            borrowPanel.Visible = true;

            panel3.Visible = true;
            reqSucPanel.Visible = false;
        }

        private void btnSelect2_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            borrowPanel.Visible = true;

            panel3.Visible = true;
            reqSucPanel.Visible = false;
        }

        private void btnSelect3_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            borrowPanel.Visible = true;

            panel3.Visible = true;
            reqSucPanel.Visible = false;
        }

        private void btnSelect4_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            borrowPanel.Visible = true;

            panel3.Visible = true;
            reqSucPanel.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            borrowPanel.Visible = true;

            panel3.Visible = true;
            reqSucPanel.Visible = false;
        }

        private void btnBorBook_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            borReqPanel.Visible = true;
            borReqPanel.BringToFront();

            panel6.Visible = true;

            reqSucPanel.Visible = false;
            approvedPanel.Visible = false;
            bookDetPanel.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            borReqPanel.Visible = true;

            panel6.Visible = true;

            approvedPanel.Visible = false;
            bookDetPanel.Visible = false;

        }

        private void btnViewBookReq_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            borReqPanel.Visible = true;

            panel6.Visible = false;
            bookDetPanel.Visible = true;
            bookDetPanel.BringToFront();
            approvedPanel.Visible = false;
        }

        private void btnEdit1_Click(object sender, EventArgs e)
        {
            brpanel.Visible = false;

            brEditPanel.Parent = mainPanel;
            brEditPanel.Dock = DockStyle.Fill;
            brEditPanel.Visible = true;

            brEditPanel.BringToFront();
        }

        private void btnUpdReq1_Click(object sender, EventArgs e)
        {
            brEditPanel.Visible = false;

            reqSucPanel.Visible = true;
            reqSucPanel.BringToFront();
        }

        private void btnCan1_Click(object sender, EventArgs e)
        {
            editReqPanel.Visible = false;

            origBookPanel.Location = editReqPanel.Location;
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to delete this request?",
        "Delete Request",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                editReqPanel.Visible = false;
                origBookPanel.Visible = false;
            }
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this request?",
                "Delete Request",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                detBPanel.Visible = false;
            }
        }

        private void btnAllAct_Click(object sender, EventArgs e)
        {
            subRetReqPanel.Visible = true;
            subRetPanel.Visible = true;
            borBookPanel1.Visible = true;

            btnAllAct.BackColor = Color.Gold;
            btnBor.BackColor = Color.White;
            btnRet.BackColor = Color.White;
        }

        private void btnBor_Click(object sender, EventArgs e)
        {
            subRetReqPanel.Visible = true;
            borBookPanel1.Visible = true;
            subRetPanel.Visible = false;

            btnAllAct.BackColor = Color.Gold;
            btnBor.BackColor = Color.White;
            btnRet.BackColor = Color.White;
            btnAllAct.BackColor = Color.White;
            btnBor.BackColor = Color.Gold;
            btnRet.BackColor = Color.White;
        }

        private void btnRet_Click(object sender, EventArgs e)
        {
            subRetReqPanel.Visible = false;
            borBookPanel1.Visible = false;
            subRetPanel.Visible = true;

            btnAllAct.BackColor = Color.Gold;
            btnBor.BackColor = Color.White;
            btnRet.BackColor = Color.White;
            btnAllAct.BackColor = Color.White;
            btnBor.BackColor = Color.White;
            btnRet.BackColor = Color.Gold;
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Return Request Submitted!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Borrow Again Clicked!",
                "Borrow Again",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnBackCat1_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            borrowPanel.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            dashboardPanel.Visible = true;
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            dashboardPanel.Visible = true;
        }

        private void btnBackCat2_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            dashboardPanel.Visible = true;
        }

        private void btnBack4_Click(object sender, EventArgs e)
        {
            brEditPanel.Visible = false;

            brpanel.Visible = true;
            brpanel.Dock = DockStyle.Fill;
            brpanel.BringToFront();
        }

        private void btnApproved_Click(object sender, EventArgs e)
        {
            approvedPanel.Visible = false;
            panel6.Visible = true;
        }

        private void btnLogOut1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                WelcomeLogin login = new WelcomeLogin();
                login.Show();

                this.Hide();
            }
        }

        private void btnCaps_Click(object sender, EventArgs e)
        {
            lblCat.Text = "CAPSTONE";

            panelFiction1.Visible = false;
            panelFiction2.Visible = false;
            panelFiction3.Visible = false;
            panelScience1.Visible = false;

            btnAll.BackColor = Color.White;
            btnFic.BackColor = Color.White;
            btnSci.BackColor = Color.White;
            btnHis.BackColor = Color.White;
            btnCaps.BackColor = Color.Gold;
        }

        private void btnHis_Click(object sender, EventArgs e)
        {
            lblCat.Text = "HISTORY";

            panelFiction1.Visible = true;
            panelFiction2.Visible = false;
            panelFiction3.Visible = false;
            panelScience1.Visible = false;

            btnAll.BackColor = Color.White;
            btnFic.BackColor = Color.White;
            btnSci.BackColor = Color.White;
            btnHis.BackColor = Color.Gold;
            btnCaps.BackColor = Color.White;
        }

        private void btnSci_Click(object sender, EventArgs e)
        {
            lblCat.Text = "SCIENCE";

            panelFiction1.Visible = false;
            panelFiction2.Visible = false;
            panelFiction3.Visible = false;
            panelScience1.Visible = true;

            btnAll.BackColor = Color.White;
            btnFic.BackColor = Color.White;
            btnSci.BackColor = Color.Gold;
            btnHis.BackColor = Color.White;
            btnCaps.BackColor = Color.White;
        }

        private void btnFic_Click(object sender, EventArgs e)
        {
            lblCat.Text = "FICTION";

            panelFiction1.Visible = true;
            panelFiction2.Visible = true;
            panelFiction3.Visible = true;
            panelScience1.Visible = false;

            btnAll.BackColor = Color.White;
            btnFic.BackColor = Color.Gold;
            btnSci.BackColor = Color.White;
            btnHis.BackColor = Color.White;
            btnCaps.BackColor = Color.White;
        }

        private void txtBorDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void dashboardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelFiction1.Visible = true;
            panelFiction2.Visible = true;
            panelFiction3.Visible = true;
            panelScience1.Visible = true;

            btnAll.BackColor = Color.Gold;
            btnFic.BackColor = Color.White;
            btnSci.BackColor = Color.White;
            btnHis.BackColor = Color.White;
            btnCaps.BackColor = Color.White;

            lblNoMatch.Visible = false;

        }
        private void btnBackCat3_Click(object sender, EventArgs e)
        {
            bookDetPanel.Visible = false;
            brpanel.Visible = true;

            detBPanel.Visible = true;
        }

        private void btnEdit2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete3_Click(object sender, EventArgs e)
        {

        }
    }
}