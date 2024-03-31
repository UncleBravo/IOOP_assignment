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
    public partial class add_recommendation : KryptonForm
    {
        public add_recommendation()
        {
            InitializeComponent();
        }

        private void user_Enter(object sender, EventArgs e)
        {
            if (member_refNo.Text == "Add Reference Number")
            {
                member_refNo.Text = "";
            }
        }

        private void user_Leave(object sender, EventArgs e)
        {
            if (member_refNo.Text == "")
            {
                member_refNo.Text = "Add Reference Number";
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
            Coach obj1 = new Coach(member_refNo.Text, competition_RefNo.Text);
            status = obj1.SendRecommendation();
            
            if (status != null)
            {
                MessageBox.Show(status);
            }

            member_refNo.Clear();
            competition_RefNo.Clear();
        }
    }
}
