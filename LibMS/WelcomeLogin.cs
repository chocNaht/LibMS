namespace LibMS
{
    public partial class WelcomeLogin : Form
    {
        string selectedRole = "";
        public WelcomeLogin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnStud_Click(object sender, EventArgs e)
        {
            selectedRole = "STUDENT";

            btnStud1.BackColor = Color.Gold;
            btnAdm1.BackColor = Color.White;
        }

        private void btnAdm1_Click(object sender, EventArgs e)
        {
            selectedRole = "ADMIN";

            btnAdm1.BackColor = Color.Gold;
            btnStud1.BackColor = Color.White;
        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            if (selectedRole == "STUDENT")
            {
                StudDash student = new StudDash();
                student.Show();

                this.Hide();
            }

            else if (selectedRole == "ADMIN")
            {
                AdmDash admin = new AdmDash();
                admin.Show();

                this.Hide();
            }

            else
            {
                MessageBox.Show("Please select Student or Admin");
            }
        }

        private void visible1_Click(object sender, EventArgs e)
        {
            visible1.Visible = false;
            hide1.Visible = true;
        }

        private void hide1_Click(object sender, EventArgs e)
        {
            visible1.Visible = true;
            hide1.Visible = false;
        }
    }
}
