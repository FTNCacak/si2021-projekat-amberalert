using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewAccount_Click(object sender, EventArgs e)
        {
            new RegistrationForm().Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxBadge.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Da biste izvršili prijavu treba da unesete broj značke i lozinku!");
            }
            if (!Regex.Match(textBoxBadge.Text, @"^\d{6}$").Success)
            {
                MessageBox.Show("Broj značke nije pravilno unet!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBadge.Focus();
                return;
            }
            else
            {
                SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AmberAlertDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Count(*) FROM PoliceOfficers WHERE PoliceBadgeNumber='" + textBoxBadge.Text + "'and Password='" + textBoxPassword.Text + "'", sqlConnection);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    new HomeForm().Show();
                }

                else
                {
                    MessageBox.Show("Pogrešan unos broja značke ili lozinke. Molimo Vas pokušajte ponovo!");
                }
            }
        }

        private void LoginBackground_Click(object sender, EventArgs e)
        {

        }
    }
}
