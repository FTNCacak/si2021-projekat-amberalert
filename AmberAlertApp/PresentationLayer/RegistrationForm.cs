using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmberAlertBusiness;
using Shared.Interfaces;
using Shared.Models;

namespace PresentationLayer
{
    public partial class RegistrationForm : Form
    {
        private readonly PoliceOfficerBusiness policeOfficerBusiness;

        public RegistrationForm()
        {
            this.policeOfficerBusiness = new PoliceOfficerBusiness();
            InitializeComponent();

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            refreshList();
        }

        private void ExitRegistration_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void refreshList()
        {
            List<PoliceOfficer> policajci = this.policeOfficerBusiness.GetAllPoliceOfficers();
            dataGridView1.DataSource = policajci;
        }


        private void buttonAddPoliceOfficer_Click(object sender, EventArgs e)
        {
            if (textBoxPoliceOfficerBadge.Text == "" || textBoxPoliceOfficerName.Text == "" || textBoxPoliceOfficerSurname.Text == "" || textBoxPoliceOfficerUsername.Text == "" || textBoxPoliceOfficerPassword.Text == "" || textBoxPoliceOfficerJob.Text == "" || textBoxPoliceOfficerMotorola.Text == "" || textBoxPoliceOfficerVehicleRegisterNumber.Text == "")
            {
                MessageBox.Show("Da biste sačuvali podatke morate popuniti prazna polja!");

            }

            if (!Regex.Match(textBoxPoliceOfficerBadge.Text, @"^\d{6}$").Success)
            {
                MessageBox.Show("Broj značke nije pravilno unet!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPoliceOfficerBadge.Focus();
                return;
            }

            if (!Regex.Match(textBoxPoliceOfficerMotorola.Text, @"^\d{4}$").Success)
            {
                MessageBox.Show("Broj motorole nije pravilno unet!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPoliceOfficerMotorola.Focus();
                return;
            }

            else
            {
                PoliceOfficer p = new PoliceOfficer();
                p.PoliceBadgeNumber = Convert.ToInt32(textBoxPoliceOfficerBadge.Text);
                p.FirstName = textBoxPoliceOfficerName.Text;
                p.SurName = textBoxPoliceOfficerSurname.Text;
                p.UserName = textBoxPoliceOfficerUsername.Text;
                p.Password = textBoxPoliceOfficerPassword.Text;
                p.PoliceDepartment = textBoxPoliceOfficerDepartment.Text;
                p.Job = textBoxPoliceOfficerJob.Text;
                p.PoliceMotorolaNumber = Convert.ToInt32(textBoxPoliceOfficerMotorola.Text);
                p.VehicleRegistrationPlate = textBoxPoliceOfficerVehicleRegisterNumber.Text;


                this.policeOfficerBusiness.PoliceIn(p);
                refreshList();


                textBoxPoliceOfficerBadge.Text = "";
                textBoxPoliceOfficerName.Text = "";
                textBoxPoliceOfficerSurname.Text = "";
                textBoxPoliceOfficerUsername.Text = "";
                textBoxPoliceOfficerPassword.Text = "";
                textBoxPoliceOfficerDepartment.Text = "";
                textBoxPoliceOfficerJob.Text = "";
                textBoxPoliceOfficerMotorola.Text = "";
                textBoxPoliceOfficerVehicleRegisterNumber.Text = "";
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
