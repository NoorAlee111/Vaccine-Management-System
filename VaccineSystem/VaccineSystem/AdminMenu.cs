using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaccineSystem
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
           
        }

        private void viewVaccineAvailabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewAllRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form SignINForm = new SignIN();
            SignINForm.Show();
            this.Close();
        }

        private void addRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form add = new AddRecord();
            add.Show();
        }

        private void viewAllRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form view = new ViewForm();
            view.Show();
        }

        private void giveAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myform =new Appoption();
            myform.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form moreform = new SignUP();
            moreform.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cardGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myform =new Card_Generation();
            myform.Show();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newform = new SearchForm();
            newform.Show();
        }

        private void viewVaccineAvailabilityToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form myform = new VaccineView();
            myform.Show();
        }

        private void vaccineRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form editvaccinForm = new EditVaccines();
            editvaccinForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
