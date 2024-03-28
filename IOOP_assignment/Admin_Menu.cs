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
    public partial class Admin_Menu : KryptonForm
    {
        public Admin_Menu()
        {
            InitializeComponent();
            
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Menu_Load(object sender, EventArgs e)
        {

        }

        private void add_user_Click(object sender, EventArgs e)
        {
            add_user_type form1 = new add_user_type();
            form1.Show();
            this.Hide();
        }

        private void view_user_Click(object sender, EventArgs e)
        {
            view_user_type form2 = new view_user_type();
            form2.Show();
            this.Hide();
        }

        private void delete_user_Click(object sender, EventArgs e)
        {
            delete_user_type form3 = new delete_user_type();
            form3.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void update_details_Click(object sender, EventArgs e)
        {
            update_profile form1 = new update_profile();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
