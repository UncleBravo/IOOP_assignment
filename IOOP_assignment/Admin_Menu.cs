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
    }
}
