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
    public partial class Admin_Menu : KryptonForm
    {
        public Admin_Menu()
        {
            InitializeComponent();
            PnlNav.Height = button1.Height;
            PnlNav.Top = button1.Top;
            PnlNav.Left = button1.Left;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PnlNav.Height = button1.Height;
            PnlNav.Top = button1.Top;
            PnlNav.Left = button1.Left;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PnlNav.Height = button2.Height;
            PnlNav.Top = button2.Top;
            PnlNav.Left = button2.Left;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PnlNav.Height = button3.Height;
            PnlNav.Top = button3.Top;
            PnlNav.Left = button3.Left;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PnlNav.Height = button4.Height;
            PnlNav.Top = button4.Top;
            PnlNav.Left = button4.Left;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PnlNav.Height = button6.Height;
            PnlNav.Top = button6.Top;
            PnlNav.Left = button6.Left;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(0, 145, 213);
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(0, 145, 213);
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(0, 145, 213);
        }

        private void button4_Leave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(0, 145, 213);
        }

        private void button6_Leave(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(0, 145, 213);
        }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
