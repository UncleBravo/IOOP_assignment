using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace IOOP_assignment
{
    public partial class Login : KryptonForm
    {
        public Login()
        {
            InitializeComponent();
            user.Focus();
        }

        

        private void password_TxtBox_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "Enter Your Password")
            {
                pass.Text = "";
                pass.UseSystemPasswordChar = true;
            }
        }

        private void password_TxtBox_Leave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                pass.Text = "Enter Your Password";
                pass.UseSystemPasswordChar = false;
            }
        }


        private void email_TxtBox_Enter(object sender, EventArgs e)
        {
            if (user.Text == "Enter Your E-Mail Address")
            {
                user.Text = "";
            }
        }

        private void email_TxtBox_Leave(object sender, EventArgs e)
        {
            if (user.Text == "")
            {
                user.Text = "Enter Your E-Mail Address";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Text != "Enter Your Password")
            {
                if (checkBox1.Checked == true)
                {
                    pass.UseSystemPasswordChar = false;
                }

                else
                {
                    pass.UseSystemPasswordChar = true;
                }
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            enrollment_form obj1 = new enrollment_form();
            obj1.Show();
            this.Hide();
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
