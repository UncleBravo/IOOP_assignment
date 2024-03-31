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
    public partial class unenrollment_form : KryptonForm
    {
        public unenrollment_form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Member_Form form1 = new Member_Form();
            form1.Show();
            this.Hide();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string status;
            Member obj1 = new Member(member_reference_number.Text);
            status = obj1.Unenroll(member_reference_number.Text);

            if (status != null)
            {
                MessageBox.Show(status);
            }

            member_reference_number.Clear();
            Reason.Clear();
        }
    }
}
