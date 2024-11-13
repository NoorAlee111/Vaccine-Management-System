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
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        { 
            gridrecords.DataSource = recordDL.Recordlist;
        }
        public void DataBind()
        {
            gridrecords.DataSource = null;
            gridrecords.DataSource = recordDL.Recordlist;
            gridrecords.Refresh();
        }

        private void gridrecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            record r = (record)gridrecords.CurrentRow.DataBoundItem;
            if (gridrecords.Columns["Delete"].Index == e.ColumnIndex)
            {
                recordDL.deleterecordFromList(r);
                recordDL.storeallDataIntoFile();
                recordDL.storecardDataIntoFile();
                recordDL.savedoseData();
                recordDL.storealltimeDataIntoFile();
                DataBind();
            }
            else if (gridrecords.Columns["Edit"].Index == e.ColumnIndex)
            {
                EditrecordForm myform = new EditrecordForm(r);
                myform.ShowDialog();
                recordDL.storeallDataIntoFile();
                recordDL.storecardDataIntoFile();
                recordDL.savedoseData();
                recordDL.storealltimeDataIntoFile();
                DataBind();
            }
        }
    }
}
