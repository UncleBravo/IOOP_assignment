using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment
{
    internal class TrainingSchedule
    {
        public string reference_number;
        public string coach_id;
        public string time;
        public string date;


        public TrainingSchedule() { }

        public TrainingSchedule(string ref_no)
        {
            string refernece_number = ref_no;
        }

        public TrainingSchedule(string ref_no, string coachID, string time, string date)
        {
            string refernece_number = ref_no;
            string coach_id = coachID;
            this.time = time;
            this.date = date;   
        }
           

        public string AddSchedule(string ref_no, string coachID, string time, string date)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdInsert = new SqlCommand("Insert into TrainingSchedule (Schedule_Refno, Coach_RefNo, time, date) VALUES (@r, @cid, @time, @date)", con);

            cmdInsert.Parameters.AddWithValue("@r", ref_no);
            cmdInsert.Parameters.AddWithValue("@cid", coachID);
            cmdInsert.Parameters.AddWithValue("@time", time);
            cmdInsert.Parameters.AddWithValue("@date", date);

            int rowaffected = cmdInsert.ExecuteNonQuery();
            if (rowaffected > 0)
                status = "Schedule added sucessfully";
            else
                status = "Process failed, please try again.";


            con.Close();
            return status;
        }


        public string DeleteSchedule()
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) from TrainingSchedule where Schedule_Refno=@refno", con);
            cmdCheck.Parameters.AddWithValue("@refno", reference_number);

            int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
            if (count > 0)
            {
                SqlCommand cmdDelete = new SqlCommand("Delete FROM TrainingSchedule WHERE Schedule_Refno = @refno", con);
                cmdDelete.Parameters.AddWithValue("@refno", reference_number);
                int rowaffected = cmdDelete.ExecuteNonQuery();

                if (rowaffected > 0)
                    status = "Details deleted sucessfully";
                else
                    status = "Process failed. Please try again";
            }

            else
            {
                status = "Schedule doesn't exist. Please try again.";
            }



            con.Close();
            return status;
        }

        public string EditSchedule()
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) from TrainingSchedule where Schedule_Refno=@refno", con);
            cmdCheck.Parameters.AddWithValue("@refno", reference_number);

            int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
            if (count > 0)
            {
                SqlCommand cmdUpdate = new SqlCommand("UPDATE TrainingSchedule SET Schedule_Refno = @refno, Coach_RefNo = @coachid, time = @time, date = @date WHERE Schedule_Refno = @refno", con);
                cmdUpdate.Parameters.AddWithValue("@refno", reference_number);
                cmdUpdate.Parameters.AddWithValue("@coachid", coach_id); 
                cmdUpdate.Parameters.AddWithValue("@time", time); 
                cmdUpdate.Parameters.AddWithValue("@date", date);
                int rowaffected = cmdUpdate.ExecuteNonQuery();

                if (rowaffected > 0)
                    status = "Details updated sucessfully";
                else
                    status = "Process failed. Please try again";
            }

            else
            {
                status = "Schedule doesn't exist. Please try again.";
            }


            con.Close();
            return status;
        }
    

    }
}
