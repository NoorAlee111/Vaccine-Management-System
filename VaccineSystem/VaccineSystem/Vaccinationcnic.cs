using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VaccineSystem
{
    public partial class cnic : Form
    {
        private string optiontype;
        public cnic(string optiontype)
        {
            InitializeComponent();
            this.optiontype = optiontype;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Vaccinationcnic_Load(object sender, EventArgs e)
        {
            if (optiontype == "vaccninestatus")
            {
                label3.Text = "USER > Vaccination status";
            }
            else if (optiontype == "vaccninecard")
            {
                label3.Text = "USER > Vaccination Card";
            }
              
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            if (cnictxt.BackColor == Color.Green)
            {
                record r = recordDL.checkuser(cnictxt.Text);
                if (optiontype == "vaccninestatus")
                {
                    Form vstatus = new VaccinationStatus(r);
                    vstatus.Show();
                }
                else if (optiontype == "vaccninecard")
                {
                    Form vcard = new VaccinationCard(r);
                    vcard.Show();
                }
                else if (optiontype == "appointment")
                {
                    Form vapp = new VaccinationAppointment(r);
                    vapp.Show();
                }
            }
            else if(cnictxt.BackColor == Color.Red)
            {
                MessageBox.Show("Invalid Cnic...");
            }
            

        }

        private void cnictxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex r = new Regex(@"^[0-9]{13}$");
            if (r.IsMatch(cnictxt.Text))
            {
                cnictxt.BackColor = Color.Green;
            }
            else
            {
                cnictxt.BackColor = Color.Red;
            }

        }

        private void cnictxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
