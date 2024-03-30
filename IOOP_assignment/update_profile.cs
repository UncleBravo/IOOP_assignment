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
    public partial class update_profile : KryptonForm
    {
        private string ref_no;
        public update_profile()
        {
            InitializeComponent();
        }

        public update_profile(string refno)
        {
            InitializeComponent();
            ref_no = refno;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
