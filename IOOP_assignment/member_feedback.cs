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
    public partial class member_feedback : KryptonForm
    {
        public member_feedback()
        {
            InitializeComponent();
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
            Member obj1 = new Member(member_reference_number.Text);
            status = obj1.SendFeedback(member_reference_number.Text, feedback.Text);

            if (status != null)
            {
                MessageBox.Show(status);
            }

            member_reference_number.Clear();
            feedback.Clear();
        }
    }
}
