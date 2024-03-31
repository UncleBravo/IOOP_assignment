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
    public partial class add_member : KryptonForm
    {
        public add_member()
        {
            InitializeComponent();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string status;
            Manager obj1 = new Manager(member_reference_number.Text, competition_reference_number.Text);
            status = obj1.AddMemberToCompetition(member_reference_number.Text, competition_reference_number.Text);

            if (status != null)
            {
                MessageBox.Show(status);
            }

            member_reference_number.Clear();
            competition_reference_number.Clear();
        }
    }
}
