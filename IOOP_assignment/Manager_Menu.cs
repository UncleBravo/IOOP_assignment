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
    }
}
