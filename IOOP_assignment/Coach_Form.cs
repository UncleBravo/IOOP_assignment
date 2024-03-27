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
    public partial class Coach_Menu : KryptonForm
    {
        public Coach_Menu()
        {
            InitializeComponent();
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Coach_Menu_Load(object sender, EventArgs e)
        {

        }

        private void add_schedule_Click(object sender, EventArgs e)
        {
            add_schedule form1 = new add_schedule();
            form1.Show();
            this.Hide();
        }

        private void delete_schedule_Click(object sender, EventArgs e)
        {
            delete_schedule form2 = new delete_schedule();
            form2.Show();
            this.Hide();
        }

        private void edit_schedule_Click(object sender, EventArgs e)
        {
            edit_schedule form3 = new edit_schedule();
            form3.Show();
            this.Hide();
        }

        private void add_result_Click(object sender, EventArgs e)
        {
            add_result form4 = new add_result();
            form4.Show();
            this.Hide();
        }

        private void add_recommendation_Click(object sender, EventArgs e)
        {
            add_recommendation form5 = new add_recommendation();
            form5.Show();
            this.Hide();
        }

        private void add_comment_Click(object sender, EventArgs e)
        {
            Comment form6 = new Comment();
            form6.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
