using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibMS
{
    public partial class StudDash : Form
    {
        private readonly List<Panel> mainPanels = new();

        public StudDash()
        {
            InitializeComponent();
            InitializePanels();
            StudDash_Load(this, EventArgs.Empty);
        }

        private void StudDash_Load(object sender, EventArgs e)
        {
            ShowPanel(dashboardPanel);
        }
    }
}