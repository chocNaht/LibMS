namespace LibMS
{
    public partial class StudDash
    {
        private void btnAllAct_Click(object sender, System.EventArgs e)
        {
            subRetPanel.Visible = true;
            subRetReqPanel.Visible = true;
            borBookPanel1.Visible = true;
        }

        private void btnBor_Click(object sender, System.EventArgs e)
        {
            subRetPanel.Visible = false;
            subRetReqPanel.Visible = true;
            borBookPanel1.Visible = true;
        }

        private void btnRet_Click(object sender, System.EventArgs e)
        {
            subRetPanel.Visible = true;
            subRetReqPanel.Visible = false;
            borBookPanel1.Visible = false;
        }
    }
}