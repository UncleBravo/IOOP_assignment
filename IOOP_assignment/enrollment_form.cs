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
    public partial class enrollment_form : KryptonForm
    {
        public enrollment_form()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Declaration form1 = new Declaration();
            form1.Show();
            this.Hide();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            string status;
            User obj1 = new User(refno.Text, role.Text, fname.Text, lname.Text, dob.Text, gen.Text, add.Text, email.Text,Convert.ToInt32(pn.Text), ecna.Text, ecn.Text, mc.Text, sport.Text, skill.Text, user.Text, pass.Text);
            status = obj1.Signup(refno.Text, role.Text, fname.Text, lname.Text, dob.Text, gen.Text, add.Text, email.Text, Convert.ToInt32(pn.Text), ecna.Text, ecn.Text, mc.Text, sport.Text, skill.Text, user.Text, pass.Text);
            if (status != null) 
            {
                MessageBox.Show(status);
            
            }
        }

        private void kryptonTextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
