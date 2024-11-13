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
    public partial class ViewbyAge : Form
    {
        public ViewbyAge()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewbyAge_Load(object sender, EventArgs e)
        {
            List<record> sortedbyage = recordDL.sortedrecordlist();
            recordgrid.DataSource = sortedbyage.Select(c => new { c.NameA1, c.CnicA1, c.AgeA1, c.GenderA1, c.PrfA1, c.Pdose1, c.BpA1, c.BtA1, c.PnoA1 }).ToList();
        }
    }
}
