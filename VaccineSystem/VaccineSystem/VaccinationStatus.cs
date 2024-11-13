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
   
    public partial class VaccinationStatus : Form
    {
        private record r;
        public VaccinationStatus(record r)
        {
            InitializeComponent();
            this.r = r;
        }

        private void VaccinationStatus_Load(object sender, EventArgs e)
        {
            if(r==null)
            {
                vaccinestatuslbl1.Text = "You've got 0 dose";
                vaccinestatuslbl2.Text = "You are not vaccinated yet.";
            }
            else 
            {
                vaccinestatuslbl1.Text = "You've got"+ r.Pdose1.ToString() +"dose";
               if(r.Pdose1==1) 
                {
                    vaccinestatuslbl2.Text = "You're partially vaccinated.";
                }
               else if(r.Pdose1 == 2)
                {
                    vaccinestatuslbl2.Text = "You're fully vaccinated.";
                }       
            if (r.AgeA1 < 15)
            {
               vaccinestatuslbl3.Text="Vaccine:Pfizer";
            }
            else if (r.AgeA1 > 15 && r.AgeA1 < 40)
            {
                vaccinestatuslbl3.Text = "Vaccine:Moderna";
            }
            else if (r.AgeA1 > 40)
            {
                vaccinestatuslbl3.Text = "Vaccine:Sinopharm";
            }
        }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
