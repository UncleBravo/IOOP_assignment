using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment
{
    internal class Coach : User
    {
        public string competition_reference; 

        public Coach(string refNo, string competionRefNo) 
        { 
            string ref_no = refNo;
            string competion_refNo = competionRefNo;
        }

        
        public string SendRecommendation()
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdInsert = new SqlCommand("Insert into Recommendations (RefNo, Competition_Reference_Number) VALUES (@r, @cr)", con);

            cmdInsert.Parameters.AddWithValue("@r", RefNo);
            cmdInsert.Parameters.AddWithValue("@cr", competition_reference);

            int rowaffected = cmdInsert.ExecuteNonQuery();
            if (rowaffected > 0)
                status = "Recommendation added sucessfully";
            else
                status = "Process failed, please try again.";


            con.Close();
            return status;
        }

        public void Comment(Member member, string comment)
        {
            // Implementation 
        }

        public void Unenroll(string trainingSchedule)
        {
            // Implementation 
        }
    }
}