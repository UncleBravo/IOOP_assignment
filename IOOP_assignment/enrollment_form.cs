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

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            if(!Authenticate())
            {
                MessageBox.Show("Field is empty.");
                return;
            }

            string Credentials = "INSERT INTO User_Credentials VALUES(@userid,@pass)";
            con.Open(); //open sql connection to access database
            cmd = new SqlCommand(Credentials, con);


            cmd.Parameters.Add("@userid", SqlDbType.VarChar);
            cmd.Parameters["@userid"].Value = user.Text;


            cmd.Parameters.Add("@pass", SqlDbType.VarChar);
            cmd.Parameters["@pass"].Value = pass.Text;

            
            
            string Secondary = "INSERT INTO Secondary_Data VALUES(@userid,@emfname,@emlname,@emcontact)";
            //open sql connection to access database
            cmd = new SqlCommand(Secondary, con);

            cmd.Parameters.Add("@userid", SqlDbType.VarChar);
            cmd.Parameters["@userid"].Value = user.Text;

            cmd.Parameters.Add("@emfname", SqlDbType.VarChar);
            cmd.Parameters["@emfname"].Value = ecfname.Text;


            cmd.Parameters.Add("@emlname", SqlDbType.VarChar);
            cmd.Parameters["@emlname"].Value = lcfname.Text;


            cmd.Parameters.Add("@emcontact", SqlDbType.VarChar);
            cmd.Parameters["@emcontact"].Value = cont.Text;
           
            string Bio_Data = "INSERT INTO User_BioData VALUES(@userid,@fname,@lname,@dob,@gender,@address,@email,@contact,@mc)";
            //open sql connection to access database
            cmd = new SqlCommand(Bio_Data, con);

            cmd.Parameters.Add("@userid", SqlDbType.VarChar);
            cmd.Parameters["@userid"].Value = user.Text;

            cmd.Parameters.Add("@fname", SqlDbType.VarChar);
            cmd.Parameters["@fname"].Value = first.Text;

            cmd.Parameters.Add("@lname", SqlDbType.VarChar);
            cmd.Parameters["@lname"].Value = last.Text;

            cmd.Parameters.Add("@dob", SqlDbType.DateTime);
            cmd.Parameters["@dob"].Value = dob.Text;

            cmd.Parameters.Add("@gender", SqlDbType.VarChar);
            cmd.Parameters["@gender"].Value = gen.Text;


            cmd.Parameters.Add("@address", SqlDbType.VarChar);
            cmd.Parameters["@address"].Value = add.Text;

            cmd.Parameters.Add("@email", SqlDbType.VarChar);
            cmd.Parameters["@email"].Value = email.Text;

            cmd.Parameters.Add("@contact", SqlDbType.VarChar);
            cmd.Parameters["@contact"].Value = phone.Text;

            cmd.Parameters.Add("@mc", SqlDbType.VarChar);
            cmd.Parameters["@mc"].Value = mc.Text;


            cmd.ExecuteNonQuery();
           

            string level = "INSERT INTO User_Skills VALUES(@userid,@sport,@skill)";
           //open sql connection to access database
            cmd = new SqlCommand(level,con);

            cmd.Parameters.Add("@userid", SqlDbType.VarChar);
            cmd.Parameters["@userid"].Value = user.Text;

            cmd.Parameters.Add("@sport", SqlDbType.VarChar);
            cmd.Parameters["@sport"].Value = sport.Text;


            cmd.Parameters.Add("@skill", SqlDbType.VarChar);
            cmd.Parameters["@skill"].Value = skill.Text;

            cmd.ExecuteNonQuery();
            con.Close();

        }
        bool Authenticate()
        {
            if (string.IsNullOrWhiteSpace(user.Text) ||
               string.IsNullOrWhiteSpace(pass.Text)
               )
                return false;
            else return true;

        }


        private void panel3_Paint(object sender, PaintEventArgs e)
            {

            }
             
           



        private void dob_ValueChanged(object sender, EventArgs e)
            { 

            }

        private void m_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void fem_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ba_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
