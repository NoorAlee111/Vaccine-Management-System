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
    public partial class VaccineView : Form
    {
        public VaccineView()
        {
            InitializeComponent();
            bool flag = VaccineDL.ReadVaccinedata();
            if (flag == true)
            {
                MessageBox.Show("Vaccine data loaded");
            }
            VaccineQlabel1.Text = (VaccineDL.Vaccines1[0].VaccineQuantity1).ToString();
            vaccinelabel1.Text = VaccineDL.Vaccines1[0].VaccineName1 + ":";
            Vaccinelabel2.Text = VaccineDL.Vaccines1[1] .VaccineName1+ ":";
            Vaccinelabel3.Text = VaccineDL.Vaccines1[2].VaccineName1 + ":";
            VaccineQlabel2.Text = (VaccineDL.Vaccines1[1].VaccineQuantity1).ToString();
            VaccineQ3.Text = (VaccineDL.Vaccines1[2].VaccineQuantity1).ToString();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vaccine1lbl_Click(object sender, EventArgs e)
        {
            
        }

        private void vaccine3lbl_Click(object sender, EventArgs e)
        {
           
        }

        private void vaccine2lbl_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void VaccineView_Load(object sender, EventArgs e)
        {

        }

        private void vacccin1qlbl_Click(object sender, EventArgs e)
        {
            
        }

        private void vaccine2qlbl_Click(object sender, EventArgs e)
        {
           
        }

        private void vaccine3qlbl_Click(object sender, EventArgs e)
        {
          
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

