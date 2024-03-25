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

namespace IOOP_assignment
{
    public partial class Login : KryptonForm
    {
        public Login()
        {
            InitializeComponent();
            email_TxtBox.Focus();
        }

        

        private void password_TxtBox_Enter(object sender, EventArgs e)
        {
            if (password_TxtBox.Text == "Enter Your Password")
            {
                password_TxtBox.Text = "";
                password_TxtBox.UseSystemPasswordChar = true;
            }
        }

        private void password_TxtBox_Leave(object sender, EventArgs e)
        {
            if (password_TxtBox.Text == "")
            {
                password_TxtBox.Text = "Enter Your Password";
                password_TxtBox.UseSystemPasswordChar = false;
            }
        }


        private void email_TxtBox_Enter(object sender, EventArgs e)
        {
            if (email_TxtBox.Text == "Enter Your E-Mail Address")
            {
                email_TxtBox.Text = "";
            }
        }

        private void email_TxtBox_Leave(object sender, EventArgs e)
        {
            if (email_TxtBox.Text == "")
            {
                email_TxtBox.Text = "Enter Your E-Mail Address";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Text != "Enter Your Password")
            {
                if (checkBox1.Checked == true)
                {
                    password_TxtBox.UseSystemPasswordChar = false;
                }

                else
                {
                    password_TxtBox.UseSystemPasswordChar = true;
                }
            }
        }
    }
}
