using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void ExitHome_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddMissing_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MissingRegistrationForm().Show();
        }

        private void buttonMissingSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchFindings().Show();
        }

        private void HomeBackground_Click(object sender, EventArgs e)
        {

        }
    }
}
