using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_assignment
{
    public partial class loading_screen : Form
    {
        public loading_screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3;

            if (panel1.Width >= 1082)
            {
                timer1.Stop();
                Login obj1 = new Login();
                obj1.Show();
                this.Hide();
            }
        }
    }
}
