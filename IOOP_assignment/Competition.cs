using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment
{
    internal class Competition
    {

        public string competition_reference_number;
        public string competition_name;
        public string time;
        public string date;

          
        public Competition() { }

        public Competition(string competition_refNo)
        {
            string competition_reference_number = competition_refNo;
        }

        public Competition(string competition_refNo, string name, string time, string date)
        {
            string competition_reference_number = competition_refNo;
            competition_name = name;
            this.time = time;
            this.date = date;
        }

        public string AddCompetition(string competition_refNo, string name, string time, string date)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdInsert = new SqlCommand("Insert into Competitions (RefNo, CompName, Time, Date) VALUES (@r, @cnm, @time, @date)", con);

            cmdInsert.Parameters.AddWithValue("@r", competition_refNo);
            cmdInsert.Parameters.AddWithValue("@cnm", name);
            cmdInsert.Parameters.AddWithValue("@time", time);
            cmdInsert.Parameters.AddWithValue("@date", date);

            int rowaffected = cmdInsert.ExecuteNonQuery();
            if (rowaffected > 0)
                status = "Competition added sucessfully";
            else
                status = "Process failed, please try again.";


            con.Close();
            return status;
        }

        public string DeleteCompetition(string competition_refNo)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) from Competitions where RefNo=@refno", con);
            cmdCheck.Parameters.AddWithValue("@refno", competition_refNo);

            int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
            if (count > 0)
            {
                SqlCommand cmdDelete = new SqlCommand("Delete FROM Competitions WHERE RefNo = @refno", con);
                cmdDelete.Parameters.AddWithValue("@refno", competition_refNo);
                int rowaffected = cmdDelete.ExecuteNonQuery();

                if (rowaffected > 0)
                    status = "Details deleted sucessfully";
                else
                    status = "Process failed. Please try again";
            }

            else
            {
                status = "Competition does not exist. Please try again.";
            }



            con.Close();
            return status;
        }
      

    }
}
