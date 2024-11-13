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
    public partial class VaccineEditForm : Form
    {
        private string vaccinename;
        public VaccineEditForm(string vaccinename)
        {
            InitializeComponent();
            this.vaccinename=vaccinename;
        }

        private void VaccineEditForm_Load(object sender, EventArgs e)
        {
            vaccinenametxt.Text = "Enter new Quantity of " + vaccinename + ":";
        }

        private void newquantitytxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void buackbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            
                int newquantity = int.Parse(newquantitytxt.Text);
               
                VaccineDL.editvaccine(vaccinename, newquantity);
                VaccineDL.savevaccineData();
                MessageBox.Show("Value is edited..");
           
        }

        private void newquantitytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
