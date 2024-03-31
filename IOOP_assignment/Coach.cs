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
        public string coach_reference_number;
        public string member_reference_number;
        public string comment;
        public string competition_reference;

        public Coach() { }

        public Coach(string refNo, string competionRefNo) 
        { 
            string ref_no = refNo;
            string competion_refNo = competionRefNo;
        }

        public Coach(string coach_refNo, string member_refNo, string comment)
        {
            string coach_ref_no = coach_refNo;
            string member_ref_no = member_refNo;
            this.comment = comment;
        }


        public string SendRecommendation(string refNo, string competionRefNo)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdInsert = new SqlCommand("Insert into Recommendations (Member_RefNo, Comp_Ref) VALUES (@r, @cr)", con);

            cmdInsert.Parameters.AddWithValue("@r", refNo);
            cmdInsert.Parameters.AddWithValue("@cr", competionRefNo);

            int rowaffected = cmdInsert.ExecuteNonQuery();
            if (rowaffected > 0)
                status = "Recommendation added sucessfully";
            else
                status = "Process failed, please try again.";


            con.Close();
            return status;
        }

        public string Comment(string coach_refNo, string member_refNo, string comment)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdInsert = new SqlCommand("Insert into Comment (Coach_Refno, Member_Refno, Comment) VALUES (@crn, @mrn, @comment)", con);

            cmdInsert.Parameters.AddWithValue("@crn", coach_refNo);
            cmdInsert.Parameters.AddWithValue("@mrn", member_refNo);
            cmdInsert.Parameters.AddWithValue("@comment", comment);

            int rowaffected = cmdInsert.ExecuteNonQuery();
            if (rowaffected > 0)
                status = "Recommendation added sucessfully";
            else
                status = "Process failed, please try again.";


            con.Close();
            return status;
        }

        public void Unenroll(string trainingSchedule)
        {
            // Implementation 
        }
    }
}