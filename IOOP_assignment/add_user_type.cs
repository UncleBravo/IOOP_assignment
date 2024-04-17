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
    public partial class add_user_type : KryptonForm
    {
        public add_user_type()
        {
            InitializeComponent();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Admin_Menu form1 = new Admin_Menu();
            form1.Show();
            this.Hide();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string status;
            Admin obj1 = new Admin(reference_number.Text);
            status = obj1.AddUser(reference_number.Text);

            if (status != null)
            {
                MessageBox.Show(status);
            }
            reference_number.Clear();


        }
    }
}
