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
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private void recommendationsForYOUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form recommendation = new RecommendationCnic();
            recommendation.Show();
        }

        private void viewYourVaccinationStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vstatus = new cnic("vaccninestatus");
            vstatus.Show();
        }

        private void getYourVaccinationCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vcard = new cnic("vaccninecard");
            vcard.Show();
        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vapp = new cnic("appointment");
            vapp.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
