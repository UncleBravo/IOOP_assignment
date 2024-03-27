using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;
using System.Diagnostics.Eventing.Reader;


namespace IOOP_assignment
{
    public partial class enrollment_form : KryptonForm
    {
        static SqlConnection con = new SqlConnection("Data Source=DESKTOP-OMT0039;Initial Catalog=UserDetails;Integrated Security=True"); // declare connection 
        static SqlCommand cmd;
        public enrollment_form()
        {
            InitializeComponent();
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click_1(object sender, EventArgs e)
        {

        }
    }
}
