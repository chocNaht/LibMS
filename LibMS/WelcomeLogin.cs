using LibMS.DBData;
using LibMS.DBData;
using Microsoft.Data.SqlClient;

namespace LibMS
{
    public partial class WelcomeLogin : Form
    {
        private string selectedRole = "";

        public WelcomeLogin()
        {
            InitializeComponent();
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

        // Login button click event handler
        private void btnLogin1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            UserRepository repo = new();

            bool valid = repo.ValidateUser(
                txtEmail1.Text.Trim(),
                txtPass1.Text,
                selectedRole);

            if (!valid)
            {
                MessageBox.Show(
                    "Invalid email, password, or role.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (selectedRole == "STUDENT")
            {
                int? userId =
                repo.GetUserId(txtEmail1.Text.Trim(), txtPass1.Text, selectedRole);

                if (userId != null)
                {
                    new StudDash(userId.Value).Show();
                    Hide();
                }
            }
            else if (selectedRole == "ADMIN")
            {
                new AdmDash().Show();
            }

            Hide();
        }

        private void visible1_Click(object sender, EventArgs e)
        {
            txtPass1.UseSystemPasswordChar = true;

            visible1.Visible = false;
            hide1.Visible = true;
        }

        private void hide1_Click(object sender, EventArgs e)
        {
            txtPass1.UseSystemPasswordChar = false;

            visible1.Visible = true;
            hide1.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }
    }
}