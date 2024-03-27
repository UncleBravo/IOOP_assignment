﻿using System;
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
    }
}