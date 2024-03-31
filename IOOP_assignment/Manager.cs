using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment
{
    internal class Manager : User   
    {

        public string competition_reference_number;
        public string result;

        public Manager() { }


        public Manager(string member_refNo, string competition_refNo)
        {
            string Refno = member_refNo;
            string competition_reference_number = competition_refNo;
        }


        public string AddResults()
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdInsert = new SqlCommand("Insert into Result (RefNo, Competition_Reference_Number) VALUES (@r, @cr)", con);

            cmdInsert.Parameters.AddWithValue("@r", RefNo);
            cmdInsert.Parameters.AddWithValue("@cr", competition_reference_number);

            int rowaffected = cmdInsert.ExecuteNonQuery();
            if (rowaffected > 0)
                status = "Member added sucessfully";
            else
                status = "Process failed, please try again.";


            con.Close();
            return status;
        }

        public string AddMemberToCompetition()
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdInsert = new SqlCommand("Insert into Participants (RefNo, Competition_Reference_Number) VALUES (@r, @cr)", con);

            cmdInsert.Parameters.AddWithValue("@r", RefNo);
            cmdInsert.Parameters.AddWithValue("@cr", competition_reference_number);

            int rowaffected = cmdInsert.ExecuteNonQuery();
            if (rowaffected > 0)
                status = "Member added sucessfully";
            else
                status = "Process failed, please try again.";


            con.Close();
            return status;
        }

        public string DeleteParticipant()
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) from Participants where RefNo=@refno", con);
            cmdCheck.Parameters.AddWithValue("@refno", RefNo);

            int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
            if (count > 0)
            {
                SqlCommand cmdDelete = new SqlCommand("Delete FROM Participants WHERE RefNo = @refno and Competition_Reference_Number = @crn", con);
                cmdDelete.Parameters.AddWithValue("@refno", RefNo);
                cmdDelete.Parameters.AddWithValue("@crn", competition_reference_number);
                int rowaffected = cmdDelete.ExecuteNonQuery();

                if (rowaffected > 0)
                    status = "Details deleted sucessfully";
                else
                    status = "Process failed. Please try again";
            }

            else
            {
                status = "Participant details do not exist in the database. Please try again.";
            }



            con.Close();
            return status;
        }
     
    }
}
