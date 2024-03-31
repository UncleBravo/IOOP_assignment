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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace IOOP_assignment
{
    public partial class Comment : KryptonForm
    {
        public Comment()
        {
            InitializeComponent();
        }

        private void user_Enter(object sender, EventArgs e)
        {
            if (coach_refNo.Text == "Add Reference Number")
            {
                coach_refNo.Text = "";
            }
        }

        private void user_Leave(object sender, EventArgs e)
        {
            if (coach_refNo.Text == "")
            {
                coach_refNo.Text = "Add Reference Number";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Coach_Menu form1 = new Coach_Menu();
            form1.Show();
            this.Hide();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string status;
            Coach obj1 = new Coach(coach_refNo.Text, member_refNo.Text, textBox1.Text);
            status = obj1.Comment(coach_refNo.Text, member_refNo.Text, textBox1.Text);

            if (status != null)
            {
                MessageBox.Show(status);
            }

            coach_refNo.Clear();
            member_refNo.Clear();
            textBox1.Clear();
        }
    }
}
