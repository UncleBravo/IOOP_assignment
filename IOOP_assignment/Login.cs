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
        private TextBox pass;

        public Login()
        {
            InitializeComponent();
        }

        private void kryptonTextBox1_Enter(object sender, EventArgs e)
        {
            if(kryptonTextBox1.Text == "Enter Your E-Mail Address")
            {
                kryptonTextBox1.Text = "";                
            }
        }

        private void kryptonTextBox1_Leave(object sender, EventArgs e)
        {
            if(kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text = "Enter Your E-Mail Address";
            }
        }

        private void kryptonTextBox2_Enter(object sender, EventArgs e)
        {
            if(kryptonTextBox2.Text == "Enter Your Password")
            {
                kryptonTextBox2.Text = "";
                kryptonTextBox2.UseSystemPasswordChar = true;
            }
        }

        private void kryptonTextBox2_Leave(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "")
            {
                kryptonTextBox2.Text = "Enter Your Password";
                kryptonTextBox2.UseSystemPasswordChar = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Text != "Enter Your Password")
            {
                if(checkBox1.Checked == true)
                {
                    kryptonTextBox2.UseSystemPasswordChar = false;
                }

                else
                {
                    kryptonTextBox2.UseSystemPasswordChar = true;
                }
            }
                       
        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
