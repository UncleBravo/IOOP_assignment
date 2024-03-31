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
    public partial class Member_Form : KryptonForm
    {
        public Member_Form()
        {
            InitializeComponent();
            
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_payment_Click(object sender, EventArgs e)
        {
            payments form1 = new payments();
            form1.Show();
            this.Hide();
        }

        private void unenrollment_button_Click(object sender, EventArgs e)
        {
            unenrollment_form form2 = new unenrollment_form();
            form2.Show();
            this.Hide();
        }

        private void send_feedback_Click(object sender, EventArgs e)
        {
            member_feedback form3 = new member_feedback();
            form3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            view_payments form4 = new view_payments();
            form4.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            view_competition form5 = new view_competition();
            form5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            view_schedule form6 = new view_schedule();
            form6.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            view_comment form7 = new view_comment();
            form7.Show();
        }
    }
}
