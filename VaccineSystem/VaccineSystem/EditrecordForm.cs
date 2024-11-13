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
    public partial class EditrecordForm : Form
    {
        private record previous;
        public EditrecordForm(record previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void EditrecordForm_Load(object sender, EventArgs e)
        {
            Nametxt.Text = previous.NameA1;
            Agetxt.Text = previous.AgeA1.ToString();
            prftxt.Text = previous.PrfA1;
            bttxt.Text = previous.BtA1.ToString();
            bptxt.Text = previous.BpA1.ToString();
            pnotxt.Text = previous.PnoA1;
            cnictxt.Text = previous.CnicA1;
            gendercb.SelectedValue = previous.GenderA1;

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            string gender = gendercb.Text.ToString(); 
            record updated = new record(Nametxt.Text, gender, pnotxt.Text, cnictxt.Text, prftxt.Text, int.Parse(Agetxt.Text), int.Parse(bptxt.Text), int.Parse(bttxt.Text));
            recordDL.EditrecordFromList(previous, updated);
            recordDL.storeallDataIntoFile();
            MessageBox.Show("Edited....");
            
        }
    }
}
