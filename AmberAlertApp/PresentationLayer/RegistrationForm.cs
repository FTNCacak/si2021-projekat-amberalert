using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*using AmberAlertBusiness;

using Shared.Interfaces.Repository;*/

namespace PresentationLayer
{
    public partial class RegistrationForm : Form
    {
        /*private readonly IPoliceOfficerRepository obj;
        PoliceOfficerBusiness policeOfficerBusiness = new PoliceOfficerBusiness(obj);*/
        



        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ExitRegistration_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void buttonAddPoliceOfficer_Click(object sender, EventArgs e)
        {
           

        }
    }
}
