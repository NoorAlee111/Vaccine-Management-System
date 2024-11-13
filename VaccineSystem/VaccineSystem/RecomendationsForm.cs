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
    public partial class RecomendationsForm : Form
    {
        record r;
        public RecomendationsForm(record r)
        {
            InitializeComponent();
            this.r = r;
        }

        private void RecomendationsForm_Load(object sender, EventArgs e)
        {
            if(r==null)
            {
                recolbl1.Text = "Get yourself registered for first vaccination dose";
                recolbl2.Text = " By option mentioned below or  by visiting your nearest vaccination centre!!";

                recolbl3.Text=  "Register yourself for First Dose";
            }
            else if (r.Pdose1 == 1)
            {

                recolbl1.Text = "Check when you should come in for a second dose...";
                 recolbl2.Text = "As 2nd dose can be taken after 21 days. ";
                recolbl3.Text = "Most of the vaccines available are two-dose vaccines. ";
                recolbl4.Text = "Check with your care provider whether you need to and when you should get it.";
                recolbl5.Text=" Second doses help boost the immune response and strengthen immunity.";
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            Form add = new AddRecord();
            add.Show();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
