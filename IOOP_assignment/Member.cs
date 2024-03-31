using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment
{
    internal class Member : User    
    {
        public string payment_reference_number;
        public string feedback;

        public Member() { }

        public Member(string member_refNo)
        {
            string RefNo = member_refNo;
        }

        public Member(string payment_refNo, string member_refNo)
        {
            string payment_reference_number = payment_refNo;
            string RefNo = member_refNo;
        }


       
        public string Pay(string payment_refNo, string member_refNo)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdInsert = new SqlCommand("Insert into PaymentDetails (Payment_RefNo, Member_RefNo) VALUES (@r, @cr)", con);

            cmdInsert.Parameters.AddWithValue("@r", payment_refNo);
            cmdInsert.Parameters.AddWithValue("@cr", member_refNo);

            int rowaffected = cmdInsert.ExecuteNonQuery();
            if (rowaffected > 0)
                status = "Payment details added sucessfully";
            else
                status = "Process failed, please try again.";


            con.Close();
            return status;
        }
        public string SendFeedback(string ref_no, string feedback)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdInsert = new SqlCommand("Insert into Feedback (RefNo, Feedback) VALUES (@r, @cr)", con);

            cmdInsert.Parameters.AddWithValue("@r", ref_no);
            cmdInsert.Parameters.AddWithValue("@cr", feedback);

            int rowaffected = cmdInsert.ExecuteNonQuery();
            if (rowaffected > 0)
                status = "Feedback sent sucessfully";
            else
                status = "Process failed, please try again.";


            con.Close();
            return status;
        }

        public string Unenroll(string member_refNo)
            {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) from AllUsers where RefNo=@username", con);
            cmdCheck.Parameters.AddWithValue("@username", member_refNo);

            int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
            if (count > 0)
            {
                SqlCommand cmdDelete = new SqlCommand("Delete FROM AllUsers WHERE RefNo = @refno", con);
                cmdDelete.Parameters.AddWithValue("@refno", member_refNo);
                int rowaffected = cmdDelete.ExecuteNonQuery();

                if (rowaffected > 0)
                    status = "Details deleted sucessfully";
                else
                    status = "Process failed. Please try again";
            }

            else
            {
                status = "User doesn't exist in the main table";
            }

            con.Close();
            return status;
        }

        public string ViewComments(string member_refNo)
            {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdInsert = new SqlCommand("Insert into Feedback (Payment_RefNo, Member_RefNo) VALUES (@r, @cr)", con);

            cmdInsert.Parameters.AddWithValue("@r", payment_refNo);
            cmdInsert.Parameters.AddWithValue("@cr", member_refNo);

            int rowaffected = cmdInsert.ExecuteNonQuery();
            if (rowaffected > 0)
                status = "Payment details added sucessfully";
            else
                status = "Process failed, please try again.";


            con.Close();
            return status;
        }
  

    }
}
