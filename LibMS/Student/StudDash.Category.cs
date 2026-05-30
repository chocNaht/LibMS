namespace LibMS
{
    public partial class StudDash
    {
        private void SetCategory(string name)
        {
            lblCat.Text = name;
        }

        private void btnFic_Click(object sender, System.EventArgs e) => SetCategory("FICTION");
        private void btnSci_Click(object sender, System.EventArgs e) => SetCategory("SCIENCE");
        private void btnHis_Click(object sender, System.EventArgs e) => SetCategory("HISTORY");
        private void btnCaps_Click(object sender, System.EventArgs e) => SetCategory("CAPSTONE");

        private void btnAll_Click(object sender, System.EventArgs e)
        {
            SetCategory("ALL");
            lblNoMatch.Visible = false;
        }
    }
}