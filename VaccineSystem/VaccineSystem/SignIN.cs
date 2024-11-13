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
    public partial class SignIN : Form
    {
        public SignIN()
    {
        InitializeComponent();
    }

    private void SignIN_Load(object sender, EventArgs e)
    {

    }
    private void ClearDataFromForm()
    {
        username.Text = " ";
        password.Text = " ";
    }

    private void button1_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    private void button2_Click(object sender, EventArgs e)
    {

        string username = this.username.Text;
        string password = this.password.Text;
        MyUser user = new MyUser(username, password);
        MyUser validuser = MyUserDL.SignIN(user);
        if (validuser != null)
        {
            bool flag = MyUser.isAdmin(validuser);
            if (flag == true)
            {
                Form Adminform = new AdminMenu();
                Adminform.Show();
                this.Close();
            }
            else
            {
                Form userform = new UserMenu();
                userform.Show();
                this.Close();
            }
        }
        else
        {
            MessageBox.Show("InValid User");
        }
        ClearDataFromForm();
    }

    private void username_KeyDown(object sender, KeyEventArgs e)
    {

    }

    private void username_KeyPress(object sender, KeyPressEventArgs e)
    {
        if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
        {
            e.Handled = true;
        }
    }
}


            }
