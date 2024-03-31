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
    public partial class Manager_Menu : KryptonForm
    {
        public Manager_Menu()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            view_recommendations form1 = new view_recommendations();
            form1.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_result_Click(object sender, EventArgs e)
        {
            add_result form1 = new add_result();
            form1.Show();
            this.Hide();
        }

        private void add_member_Click(object sender, EventArgs e)
        {
            add_member form2 = new add_member();
            form2.Show();
            this.Hide();
        }

        private void delete_member_Click(object sender, EventArgs e)
        {
            delete_member form3 = new delete_member();
            form3.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            add_competition form4 = new add_competition();
            form4.Show();
            this.Hide();
        }

        private void delete_competition_Click(object sender, EventArgs e)
        {
            delete_competition form5 = new delete_competition();
            form5.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            view_competition form6 = new view_competition();
            form6.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            view_participants form7 = new view_participants();
            form7.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            view_results form8 = new view_results();
            form8.Show();
        }

        private void coach_view_Click(object sender, EventArgs e)
        {
            view_user form9 = new view_user();
            form9.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            update_profile update_Profile = new update_profile();
            update_Profile.Show();
        }
    }
}
