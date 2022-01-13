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
using Shared.Models;

namespace PresentationLayer
{
    public partial class SearchFindings : Form
    {
        private readonly FinidingBusiness finidingBusiness;
        public SearchFindings()
        {
            this.finidingBusiness = new FinidingBusiness();
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm().Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchFindings_Load(object sender, EventArgs e)
        {
            refreshList();
        }

        public void refreshList()
        {
            List<Find> pronalasci = this.finidingBusiness.GetFindings();
            dataGridView1.DataSource = pronalasci;
        }

        private void buttonAddFinding_Click(object sender, EventArgs e)
        {
            if (dateTimePickerDateOfFinding.Value == DateTime.Now || textBoxFindingLocation.Text == "" || checkBoxFindingAlive.Checked == false || textBoxIdPolice.Text == "" || textBoxIdFinding.Text == "")
            {
                MessageBox.Show("Da biste sačuvali podatke morate popuniti prazna polja!");

            }

            else
            {
                Find f = new Find();
                f.DateOfFinding = dateTimePickerDateOfFinding.Value;
                f.Location = textBoxFindingLocation.Text;
                f.Dead = checkBoxFindingAlive.Checked;
                f.PoliceId = Convert.ToInt32(textBoxIdPolice.Text);
                f.IdMis = Convert.ToInt32(textBoxIdFinding.Text);


                this.finidingBusiness.FindingsIn(f);
                refreshList();

                dateTimePickerDateOfFinding.Value = DateTime.Now;
                textBoxFindingLocation.Text = "";
                checkBoxFindingAlive.Checked = false;
                textBoxIdPolice.Text = "";
                textBoxIdFinding.Text = "";
            }
        }
    }
}
