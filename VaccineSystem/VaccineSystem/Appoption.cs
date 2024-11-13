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
    public partial class Appoption : Form
    {
        public Appoption()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            record r = (record)dataGridView1.CurrentRow.DataBoundItem;
            if (dataGridView1.Columns["SetTime"].Index == e.ColumnIndex)
            {
                Edittime myform = new Edittime(r);
                myform.ShowDialog();
                DataBind();

            }
        }

        private void Appoption_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = recordDL.Recordlist;
        }
        public void DataBind()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = recordDL.Recordlist;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form viewtime = new View_time();
            viewtime.Show();

        }
    }
}
