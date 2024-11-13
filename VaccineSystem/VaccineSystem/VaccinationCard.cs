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
    public partial class VaccinationCard : Form
    {
        private record r;
        public VaccinationCard(record r)
        {
            InitializeComponent();
            this.r = r;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VaccinationCard_Load(object sender, EventArgs e)
        {
            if(r==null)
            {
                MessageBox.Show("You're not vaccinated yet");
                this.Close();
            }
            else if(r.Cgeneration1==0)
            {
                MessageBox.Show("Your card is not generated yet!");
                this.Close();
            }
            else if(r.Cgeneration1 == 1)
            {
                namelbl2.Text = r.NameA1;
                agelbl1.Text = r.AgeA1.ToString();
                cniclbl1.Text = r.CnicA1;
                doselbl1.Text = r.Pdose1.ToString();
                if (r.AgeA1 <= 15)
                {
                vaccinelbl1.Text="Pfizer";
                }
                else if (r.AgeA1 > 15 && r.AgeA1 <= 40)
                {
                    vaccinelbl1.Text = "Moderna";
                }
                else if (r.AgeA1 > 40)
                {
                    vaccinelbl1.Text = "Sinopharm";
                }
                if (r.Pdose1 == 1)
                {
                    vaccinestatuslbl.Text="Partially_Vaccinated!";
                }
                else if(r.Pdose1==2)
                {
                    vaccinestatuslbl.Text = "Fully_Vaccinated!";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
