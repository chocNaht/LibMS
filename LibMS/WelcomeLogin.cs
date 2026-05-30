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

            txtEmail1.Clear();
            txtPass1.Clear();
        }

        private void btnAdm1_Click(object sender, EventArgs e)
        {
            selectedRole = "ADMIN";

            btnAdm1.BackColor = Color.Gold;
            btnStud1.BackColor = Color.White;

            txtEmail1.Clear();
            txtPass1.Clear();
        }

        // Login button click event handler
        private void btnLogin1_Click(object sender, EventArgs e)
        {
            UserRepository repo = new();

            string email = txtEmail1.Text.Trim();
            string password = txtPass1.Text;

            if (!repo.UserExists(email, password))
            {
                MessageBox.Show(
                    "Account does not exist.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            string? role = repo.GetUserRole(email, password);

            if (role == "STUDENT")
            {
                new StudDash().Show();
                Hide();
            }
            else if (role == "ADMIN")
            {
                new AdmDash().Show();
                Hide();
            }
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