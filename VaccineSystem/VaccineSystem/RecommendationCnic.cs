using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VaccineSystem
{
    public partial class RecommendationCnic : Form
    {
        public RecommendationCnic()
        {
            InitializeComponent();
        }

        private void cnictxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            if(cnictxt.BackColor==Color.Green)
            {
                record r = recordDL.checkuser(cnictxt.Text);
                if (r == null || r.Pdose1 == 1)
                {
                    Form recomndation = new RecomendationsForm(r);
                    recomndation.Show();
                }
                else if (r.Pdose1 == 2)
                {
                    Form recommendation = new RecommendationForm2();
                    recommendation.Show();
                }
            }
            else if (cnictxt.BackColor == Color.Red)
            {
                MessageBox.Show("Invalid Cnic....");
            }



        }

        private void RecommendationCnic_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cnictxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex r = new Regex(@"^[0-9]{13}$");
            if (r.IsMatch(cnictxt.Text))
            {
                cnictxt.BackColor = Color.Green;
            }
            else
            {
                cnictxt.BackColor = Color.Red;
            }
        }
    }
}
