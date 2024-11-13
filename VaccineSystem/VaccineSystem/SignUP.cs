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
    public partial class SignUP : Form
    {
        public SignUP()
        {
            InitializeComponent();
        }

        private void SignUP_Load(object sender, EventArgs e)
        {

        }
        private void CleardataFromForm()
        {
            Username1.Text = " ";
            Password.Text = " ";
            Role.Text = " ";
        }

        private void next_Click(object sender, EventArgs e)
        {

            string Username1 = this.Username1.Text;
            bool flag = MyUserDL.Checkuniqueusername(Username1);
                if(flag == false) {
                MessageBox.Show("This username is taken already...");
                  }
            else
            {
                string Password = this.Password.Text;
                string Role = this.Role.Text;
                string path = "C:\\Users\\DELL\\source\\repos\\VaccineSystem\\user.txt";
                MyUser user = new MyUser(Username1, Password, Role);
                MyUserDL.adduserintolist(user);
                MyUserDL.StoreUserData(path, user);
                MessageBox.Show("User added Succesfully");
                CleardataFromForm();
            }
           
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Role_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Username1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
