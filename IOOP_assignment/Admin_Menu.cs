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
            view_user form2 = new view_user();
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

        private void pictureBox22_Click(object sender, EventArgs e)
        {
           
        }

        private void waiting_list_button_Click(object sender, EventArgs e)
        {
            view_waiting_list form4 = new view_waiting_list();
            form4.Show();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            view_competition form5 = new view_competition();
            form5.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            view_monthly form8 = new view_monthly();
            form8.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            view_feedback form6 = new view_feedback();
            form6.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            view_results form7 = new view_results();
            form7.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            view_salaries form9 = new view_salaries();
            form9.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            view_fees form10 = new view_fees();
            form10.Show();
        }
    }
}
