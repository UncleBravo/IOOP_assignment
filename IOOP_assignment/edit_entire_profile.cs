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
    public partial class edit_entire_profile : KryptonForm
    {
        public edit_entire_profile()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string status;
            Admin obj1 = new Admin();
            status = obj1.EditProfile(refno.Text, role.Text, fname.Text, lname.Text, gen.Text, add.Text, email.Text, pn.Text, ecna.Text, ecn.Text, mc.Text, sport.Text, skill.Text, user.Text, pass.Text);
            if (status != null)
            {
                MessageBox.Show(status);

            }

            this.Hide();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Admin_Menu form = new Admin_Menu();
            form.Show();
        }

        private void kryptonTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void refno_Enter(object sender, EventArgs e)
        {
            if (refno.Text == "Add Existing Reference Number")
            {
                refno.Text = "";
            }
        }

        private void refno_Leave(object sender, EventArgs e)
        {
            if (refno.Text == "")
            {
                pass.Text = "Add Existing Reference Number";
            }
        }
    }
}
