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
    public partial class Edittime : Form
    {
        private record previous;
        public Edittime(record previous)
        {
            InitializeComponent();
            this.previous=previous;
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if( (int.Parse(timetxt.Text)) > 12)
                {
                    throw new Exception("Invalid Time..Please enter valid Time..");
                }
                else if( int.Parse(datetxt.Text)>31)
                {
                    throw new Exception("Invalid DATE..Please enter valid DATE...");
                }
                else if( int.Parse(monthtxt.Text)>12)
                {
                    throw new Exception("Invalid Month..Please enter valid Month...");
                }
                record updated = new record(int.Parse(timetxt.Text), int.Parse(datetxt.Text), int.Parse(monthtxt.Text));
                record r = recordDL.EditTime(previous, updated);
                recordDL.storealltimeDataIntoFile();
                this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Edittime_Load(object sender, EventArgs e)
        {
            timetxt.Text = previous.Appointment.Time.ToString();
            datetxt.Text= previous.Appointment.Date.ToString();
            monthtxt.Text= previous.Appointment.Month.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void datetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void monthtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
