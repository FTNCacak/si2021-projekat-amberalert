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
using DataAccessLayer;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;

namespace PresentationLayer
{
    public partial class RegistrationForm : Form
    {
        private readonly IPoliceOfficerBusiness policeOfficerBusiness;
        public RegistrationForm()
        {
            IPoliceOfficerRepository _policeOfficerRepository = new PoliceOfficerRepository();
            this.policeOfficerBusiness = new PoliceOfficerBusiness(_policeOfficerRepository);
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPoliceOfficerVehicleRegisterNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddPoliceOfficer_Click(object sender, EventArgs e)
        {
            if (textBoxPoliceOfficerBadge.Text == "" || textBoxPoliceOfficerName.Text == "" || textBoxPoliceOfficerSurname.Text=="" || textBoxPoliceOfficerUsername.Text == "" || textBoxPoliceOfficerPassword.Text == "" || textBoxPoliceOfficerDepartment.Text=="" || textBoxPoliceOfficerJob.Text==""|| textBoxPoliceOfficerMotorola.Text==""|| textBoxPoliceOfficerVehicleRegisterNumber.Text=="")
            {
                MessageBox.Show("Da biste sačuvali podatke morate popuniti prazna polja!");

            }
            if (!Regex.Match(textBoxPoliceOfficerBadge.Text, @"^\d{6}$").Success)
            {
                MessageBox.Show("Broj značke nije pravilno unet!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPoliceOfficerBadge.Focus();
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




                policeOfficerBusiness.PoliceIn(p);
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

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            refreshList();
        }

        public void refreshList()
        {
            List<PoliceOfficer> policajci = this.policeOfficerBusiness.GetAllPoliceOfficers();
            dataGridView1.DataSource = policajci;
        }

        private void Registration_Enter(object sender, EventArgs e)
        {

        }
    }
}
