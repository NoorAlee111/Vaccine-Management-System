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
    public partial class EditVaccines : Form
    {
        public EditVaccines()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pfizercb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if(Pfizercb.Checked)
            {
                Form editform = new VaccineEditForm(VaccineDL.Vaccines1[0].VaccineName1);
                editform.Show();
            }
            else if(sinopharmcb.Checked)
            {
                Form editform = new VaccineEditForm(VaccineDL.Vaccines1[1].VaccineName1);
                editform.Show();
            }
            else if(modernacb.Checked)
            {
                Form editform = new VaccineEditForm(VaccineDL.Vaccines1[2].VaccineName1);
                editform.Show();
            }
        }

        private void EditVaccines_Load(object sender, EventArgs e)
        {

        }
    }
}
