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
    public partial class SignApp : Form
    {
        public SignApp()
        {
            InitializeComponent();
            string path = "C:\\Users\\DELL\\source\\repos\\VaccineSystem\\user.txt";
            if (MyUserDL.ReadUserData(path))
            {
                MessageBox.Show("Data loaded from the file");
            }
            else
            {
                MessageBox.Show("Data not loaded...");
            }
            bool flag = recordDL.ReadRecordData();
            if (flag == true)
            {
                MessageBox.Show("Record Data is Loaded");
            }
             bool flag1 = recordDL.ReadCarddata();
            if (flag1 == true)
            {
                MessageBox.Show("Card data read");
            }
            bool flag2 = recordDL.ReadDosedata();
            if (flag2 == true)
            {
                MessageBox.Show("Dose data stored");
            }

            Vaccine v = new Vaccine("Pfizer");
            Vaccine v1 = new Vaccine("Sinopharm");
            Vaccine v2 = new Vaccine("Moderna");
            VaccineDL.Vaccines1.Add(v);
            VaccineDL.Vaccines1.Add(v1);
            VaccineDL.Vaccines1.Add(v2);
            bool flag3 = VaccineDL.ReadVaccinedata();
            if (flag3 == true)
            {
                MessageBox.Show("Vaccine data loaded");
            }
             bool flag4 = recordDL.ReadTimeData();
            if (flag4 == true)
            {
              MessageBox.Show("Time data loaded");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Form moreform = new SignIN();
                moreform.Show();
                checkBox1.Checked = false;

            }
            else if (checkBox2.Checked)
            {
                Form moreform = new SignUP();
                moreform.Show();
                checkBox2.Checked = false;
            }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    if (checkBox2.Checked)
                    {
                        checkBox2.Checked = false;
                        throw new Exception("You can select only one option at a time..");
                        
                    }
                }
                
                if (checkBox2.Checked)
                {
                    if (checkBox1.Checked)
                    {
                        checkBox1.Checked = false;
                        throw new Exception("You can select only one option at a time..");
                       
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    if (checkBox2.Checked)
                    {
                        checkBox2.Checked = false;
                        throw new Exception("You can select only one option at a time..");

                    }
                }

                if (checkBox2.Checked)
                {
                    if (checkBox1.Checked)
                    {
                        checkBox1.Checked = false;
                        throw new Exception("You can select only one option at a time..");

                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
