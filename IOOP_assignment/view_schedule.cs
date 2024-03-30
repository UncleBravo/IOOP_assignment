using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace IOOP_assignment
{
    public partial class view_schedule : KryptonForm
    {
        public view_schedule()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Feedback", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);


            con.Close();
            feed.DataSource = dtbl;
        }
    }
}
