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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace IOOP_assignment
{
    public partial class delete_competition : KryptonForm
    {
        public delete_competition()
        {
            InitializeComponent();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Manager_Menu form1 = new Manager_Menu();
            form1.Show();
            this.Hide();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string status;
            Competition obj1 = new Competition(competition_reference_number.Text);
            status = obj1.DeleteCompetition(competition_reference_number.Text);

            if (status != null)
            {
                MessageBox.Show(status);
            }

            competition_reference_number.Clear();
        }
    }
}
