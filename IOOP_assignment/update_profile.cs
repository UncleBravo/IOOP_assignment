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
    public partial class update_profile : KryptonForm
    {
        public update_profile()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (new_passsword.Text == confirm_new_password.Text)
            {
                string status;
                User obj1 = new User(reference_number.Text, confirm_new_password.Text);
                status = obj1.update_user(reference_number.Text, confirm_new_password.Text);
                
                if (status != null)
                {
                    MessageBox.Show(status);
                }
               
            }
            
        }
    }
}
