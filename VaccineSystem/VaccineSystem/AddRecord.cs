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
    public partial class AddRecord : Form
    {
        public AddRecord()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Nametxt.Text != "" && Agetxt.Text != "" && prftxt.Text != "" && bttxt.Text != "" && bptxt.Text != "" && pnotxt.Text != "" && cnictxt.Text != "")
                {
                    if(int.Parse(Agetxt.Text)>120)
                    {
                        throw new Exception("Invalid Age..Please enter valid Age..");
                    }
             
                    if (pnotxt.BackColor == Color.Green)
                    {
                        if (cnictxt.BackColor == Color.Green)
                        {
                            string gender = gendercb.Text.ToString();

                            record r = new record(Nametxt.Text, gender, pnotxt.Text, cnictxt.Text, prftxt.Text, int.Parse(Agetxt.Text), int.Parse(bptxt.Text), int.Parse(bttxt.Text));
                            if (recordDL.isexist(r))
                            {
                                r.Pdose1 = 2;
                            }
                            else
                            {
                                r.Pdose1 = 1;
                            }

                            recordDL.addintoList(r);
                            recordDL.StoreRecordsData(r);

                            MessageBox.Show("Record is added");
                            recordDL.savedoseData();
                            recordDL.storealltimeDataIntoFile();
                            recordDL.storecardDataIntoFile();

                        }
                        else if (cnictxt.BackColor == Color.Red)
                        {
                            MessageBox.Show("Invalid Cnic...");
                        }
                    }
                    else if (cnictxt.BackColor == Color.Red)
                    {
                        MessageBox.Show("Invalid Phone no...");
                    }

                }
                else
                {
                    MessageBox.Show("Fill all required information....");
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRecord_Load(object sender, EventArgs e)
        {

        }

        private void Nametxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Nametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Agetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void prftxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void bttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void bptxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void pnotxt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pnotxt_TextChanged(object sender, EventArgs e)
        {

            Regex r = new Regex(@"^[0-9]{11}$");
            if (r.IsMatch(pnotxt.Text))
            {
                pnotxt.BackColor = Color.Green;
            }
            else
            {
                pnotxt.BackColor = Color.Red;
            }
        }

        private void cnictxt_TextChanged(object sender, EventArgs e)
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
