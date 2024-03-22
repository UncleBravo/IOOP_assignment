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
    public partial class Form1 : KryptonForm
    {
        public Form1()
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
            }
        }

        private void kryptonTextBox2_Leave(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "")
            {
                kryptonTextBox2.Text = "Enter Your Password";
            }
        }
    }
}
