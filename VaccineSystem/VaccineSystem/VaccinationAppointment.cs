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
    public partial class VaccinationAppointment : Form
    {
       private record r;
        public VaccinationAppointment(record r)
        {
            InitializeComponent();
            this.r = r;
        }

        private void VaccinationAppointment_Load(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("You are not registered yet.....");
                this.Close();
            }
            else {
                if (r.Appointment.Date == 0)
                {
                    MessageBox.Show("You'll get your appointment time soon....");
                    this.Close();
                }
                else if (r.Appointment.Date != 0)
                {
                    applbl.Text = "Your appointment time is Date:" + r.Appointment.Date + " Time:" + r.Appointment.Time + ":00" + " Month:" + r.Appointment.Month;

                }
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
