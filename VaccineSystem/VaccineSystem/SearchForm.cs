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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            if(agecb.Checked)
            {
                Form newform = new ViewbyAge();
                newform.Show();
            }
            else if(gendercb.Checked)
            {
                selectgender.Visible = true;
                string selectedgender = selectgender.Text.ToString();
                Form myform = new viewbygender(selectedgender);
                myform.Show();
            }
        }

        private void gendercb_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
