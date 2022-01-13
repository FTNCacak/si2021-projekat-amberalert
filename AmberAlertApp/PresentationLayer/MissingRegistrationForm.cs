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
using Shared.Models;

namespace PresentationLayer
{
    public partial class MissingRegistrationForm : Form
    {
        private readonly MissingBusiness missingBusiness;
        public MissingRegistrationForm()
        {
            this.missingBusiness = new MissingBusiness();
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm().Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int selektor;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selektor = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxMissingName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxMissingSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxMissingJMBG.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePickerMissingDateOfBirth.Value = DateTime.Now;
            textBoxMissingAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxMissingGender.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePickerMissingDate.Value = DateTime.Now;
            checkBoxMissingPhoto.Checked = false;
        }

        private void buttonMissingAdd_Click(object sender, EventArgs e)
        {
            if (textBoxMissingName.Text == "" || textBoxMissingSurname.Text == "" || textBoxMissingJMBG.Text == "" || dateTimePickerMissingDateOfBirth.Value == DateTime.Now || textBoxMissingAddress.Text == "" || textBoxMissingGender.Text == "" || dateTimePickerMissingDate.Value == DateTime.Now || checkBoxMissingPhoto.Checked == false)
            {
                MessageBox.Show("Da biste sačuvali podatke morate popuniti prazna polja!");

            }

            if (!Regex.Match(textBoxMissingJMBG.Text, @"^\d{13}$").Success)
            {
                MessageBox.Show("JMBG mora imati 13 karaktera!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxMissingJMBG.Focus();
                return;
            }



            else
            {
                Missing m = new Missing();

                m.FirstName = textBoxMissingName.Text;
                m.SurName = textBoxMissingSurname.Text;
                m.JMBG = Convert.ToInt32(textBoxMissingJMBG.Text);
                m.DateOfBirth = dateTimePickerMissingDateOfBirth.Value;
                m.Address = textBoxMissingAddress.Text;
                m.Gender = textBoxMissingGender.Text;
                m.DateOfDisappearance = dateTimePickerMissingDate.Value;
                m.ImageOfPerson = checkBoxMissingPhoto.Checked;



                this.missingBusiness.MissingIn(m);
                refreshList();


                textBoxMissingName.Text = "";
                textBoxMissingSurname.Text = "";
                textBoxMissingJMBG.Text = "";
                dateTimePickerMissingDateOfBirth.Value = DateTime.Now;
                textBoxMissingAddress.Text = "";
                textBoxMissingGender.Text = "";
                dateTimePickerMissingDate.Value = DateTime.Now;
                checkBoxMissingPhoto.Checked = false;
            }
        }

        private void buttonMissingUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxMissingName.Text == "" || textBoxMissingSurname.Text == "" || textBoxMissingJMBG.Text == "" || dateTimePickerMissingDateOfBirth.Value == DateTime.Now || textBoxMissingAddress.Text == "" || textBoxMissingGender.Text == "" || dateTimePickerMissingDate.Value == DateTime.Now || checkBoxMissingPhoto.Checked == false)
            {
                MessageBox.Show("Da biste izmenili podatke morate popuniti prazna polja!");

            }

            if (!Regex.Match(textBoxMissingJMBG.Text, @"^\d{13}$").Success)
            {
                MessageBox.Show("JMBG mora imati 13 karaktera!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxMissingJMBG.Focus();
                return;
            }



            else
            {
                Missing m = new Missing();

                m.FirstName = textBoxMissingName.Text;
                m.SurName = textBoxMissingSurname.Text;
                m.JMBG = Convert.ToInt32(textBoxMissingJMBG.Text);
                m.DateOfBirth = dateTimePickerMissingDateOfBirth.Value;
                m.Address = textBoxMissingAddress.Text;
                m.Gender = textBoxMissingGender.Text;
                m.DateOfDisappearance = dateTimePickerMissingDate.Value;
                m.ImageOfPerson = checkBoxMissingPhoto.Checked;


                m.IdMiss = selektor;
                refreshList();


                textBoxMissingName.Text = "";
                textBoxMissingSurname.Text = "";
                textBoxMissingJMBG.Text = "";
                dateTimePickerMissingDateOfBirth.Value = DateTime.Now;
                textBoxMissingAddress.Text = "";
                textBoxMissingGender.Text = "";
                dateTimePickerMissingDate.Value = DateTime.Now;
                checkBoxMissingPhoto.Checked = false;
            }
        }

        private void buttonMissingDelete_Click(object sender, EventArgs e)
        {
            if (textBoxMissingName.Text == "" || textBoxMissingSurname.Text == "" || textBoxMissingJMBG.Text == "" || dateTimePickerMissingDateOfBirth.Value == DateTime.Now || textBoxMissingAddress.Text == "" || textBoxMissingGender.Text == "" || dateTimePickerMissingDate.Value == DateTime.Now || checkBoxMissingPhoto.Checked == false)
            {
                MessageBox.Show("Da biste obrisali podatke o osobi morate selektovati osobu!");

            }

            if (!Regex.Match(textBoxMissingJMBG.Text, @"^\d{13}$").Success)
            {
                MessageBox.Show("JMBG mora imati 13 karaktera!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxMissingJMBG.Focus();
                return;
            }



            else
            {
                Missing m = new Missing();

                m.FirstName = textBoxMissingName.Text;
                m.SurName = textBoxMissingSurname.Text;
                m.JMBG = Convert.ToInt32(textBoxMissingJMBG.Text);
                m.DateOfBirth = dateTimePickerMissingDateOfBirth.Value;
                m.Address = textBoxMissingAddress.Text;
                m.Gender = textBoxMissingGender.Text;
                m.DateOfDisappearance = dateTimePickerMissingDate.Value;
                m.ImageOfPerson = checkBoxMissingPhoto.Checked;


                m.IdMiss = selektor;
                refreshList();


                textBoxMissingName.Text = "";
                textBoxMissingSurname.Text = "";
                textBoxMissingJMBG.Text = "";
                dateTimePickerMissingDateOfBirth.Value = DateTime.Now;
                textBoxMissingAddress.Text = "";
                textBoxMissingGender.Text = "";
                dateTimePickerMissingDate.Value = DateTime.Now;
                checkBoxMissingPhoto.Checked = false;
            }
        }

        private void MissingRegistrationForm_Load(object sender, EventArgs e)
        {
            refreshList();
        }

        public void refreshList()
        {
            List<Missing> nestali = this.missingBusiness.MissingAll();
            dataGridView1.DataSource = nestali;
        }
    }
}
