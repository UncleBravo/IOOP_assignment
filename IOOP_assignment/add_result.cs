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
    public partial class add_result : KryptonForm
    {
        public add_result()
        {
            InitializeComponent();
        }

        private void user_Enter(object sender, EventArgs e)
        {
            if (competition_reference_number.Text == "Add Reference Number")
            {
                competition_reference_number.Text = "";
            }
        }

        private void user_Leave(object sender, EventArgs e)
        {
            if (competition_reference_number.Text == "")
            {
                competition_reference_number.Text = "Add Reference Number";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
            Manager obj1 = new Manager(competition_reference_number.Text, result.Text);
            status = obj1.AddResults(competition_reference_number.Text, result.Text);

            if (status != null)
            {
                MessageBox.Show(status);
            }

            competition_reference_number.Clear();

        }
 
    }
}
