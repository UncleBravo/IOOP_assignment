using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment
{
    internal class Admin : User
    {
        public Admin() { }
        public Admin(string ref_no)
        {
            RefNo = ref_no;
        }

        public string delete_user(string ref_no)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) from AllUsers where RefNo=@username", con);
            cmdCheck.Parameters.AddWithValue("@username", ref_no);

            int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
            if (count > 0)
            {
                SqlCommand cmdDelete = new SqlCommand("Delete FROM AllUsers WHERE RefNo = @refno", con);
                cmdDelete.Parameters.AddWithValue("@refno", ref_no);
                int rowaffected = cmdDelete.ExecuteNonQuery();

                if (rowaffected > 0)
                    status = "Details deleted sucessfully";
                else
                    status = "Process failed. Please try again";
            }

            else
            {
                status = "User doesn't exists in the main table";
            }



            con.Close();
            return status;
        }

        public DataTable view_users()
        {
           
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM AllUsers", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);


            con.Close();
            return dtbl;
        }

    }
}
