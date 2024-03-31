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
    public partial class add_competition : KryptonForm
    {
        public add_competition()
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
            Competition obj1 = new Competition(reference_number.Text, competition_name.Text, time.Text, date.Text);
            status = obj1.AddCompetition();

            if (status != null)
            {
                MessageBox.Show(status);
            }

            reference_number.Clear();
            competition_name.Clear();
            time.Clear();
        }
    }
}
