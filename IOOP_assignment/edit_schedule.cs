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
    public partial class edit_schedule : KryptonForm
    {
        public edit_schedule()
        {
            InitializeComponent();
        }

        private void user_Enter(object sender, EventArgs e)
        {
            if (reference_number.Text == "Add Reference Number")
            {
                reference_number.Text = "";
            }
        }

        private void user_Leave(object sender, EventArgs e)
        {
            if (reference_number.Text == "")
            {
                reference_number.Text = "Add Reference Number";
            }
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
            TrainingSchedule obj1 = new TrainingSchedule(reference_number.Text, coach_id.Text, time.Text, date.Text);
            status = obj1.EditSchedule(reference_number.Text, coach_id.Text, time.Text, date.Text);

            if (status != null)
            {
                MessageBox.Show(status);
            }

            reference_number.Clear();
            coach_id.Clear();
            time.Clear();
        }
    }
}
