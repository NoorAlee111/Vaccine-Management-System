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
    public partial class viewbygender : Form
    {
        private string selectedgender;
        public viewbygender(string selectedgender)
        {
            InitializeComponent();
            this.selectedgender = selectedgender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void viewbygender_Load(object sender, EventArgs e)
        {
            gridgender.DataSource = recordDL.getgenderlist(selectedgender).Select(c => new { c.NameA1, c.CnicA1, c.AgeA1, c.GenderA1, c.PrfA1, c.Pdose1, c.BpA1, c.BtA1, c.PnoA1 }).ToList();
        }
    }
}
