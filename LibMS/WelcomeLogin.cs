using Microsoft.Data.SqlClient;
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

        private void btnLogin1_Click(object sender, EventArgs e)
        {
             string emailAddress = txtEmail1.Text;
             string password = txtPass1.Text;

             string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kenum\source\repos\LibMS\LibMS\App_Data\db_LibMS.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
             string login = "SELECT COUNT(*) FROM Users WHERE Email=@email AND Pass=@password";

             using (Microsoft.Data.SqlClient.SqlConnection cons = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
              {
               cons.Open();
             using (SqlCommand commandDB = new SqlCommand(login, cons))
              {
               commandDB.Parameters.AddWithValue("@email", emailAddress);
               commandDB.Parameters.AddWithValue("@password", password);
               int users = (int)commandDB.ExecuteScalar();
             
               if (selectedRole == "STUDENT")
                {
                  if (users > 0)
                   {
                    StudDash student = new StudDash();
                     student.Show();

                    this.Hide();
                } else {
                 MessageBox.Show("Invalid username or password.");
                    }
         
                } else if (selectedRole == "ADMIN")
                  { 
                   if (users > 0) {
                      AdmDash admin = new AdmDash();
                      admin.Show();

                      this.Hide();
                 } else { 
                 MessageBox.Show("Invalid username or password.");
             }
          }
       }
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
    }
}
