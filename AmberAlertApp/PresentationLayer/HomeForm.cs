using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmberAlertBusiness;
using DataAccessLayer;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;

namespace PresentationLayer
{
   
    public partial class HomeForm : Form
    {
        private readonly IFindingBusiness findingBusiness;
        public HomeForm()
        {
            IFindingRepository _findingRepository = new FindingRepository();
            this.findingBusiness = new FinidingBusiness(_findingRepository);
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
