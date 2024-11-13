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
    public partial class View_time : Form
    {
        public View_time()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_time_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = recordDL.Recordlist.Select(c => new { c.NameA1, c.CnicA1, c.Appointment.Time, c.Appointment.Date, c.Appointment.Month }).ToList();
        }
    }
}
