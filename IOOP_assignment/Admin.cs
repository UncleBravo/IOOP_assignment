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
                status = "User doesn't exist in the main table";
            }



            con.Close();
            return status;
        }

        public string AddUser(string ref_no)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) from Waiting_List where RefNo=@username", con);
            cmdCheck.Parameters.AddWithValue("@username", ref_no);

            int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
            if (count > 0)
            {
                string sqlQuery = @"
                INSERT INTO AllUsers (RefNo, UserType, Fname, Lname, Gender, Address, Email, Contact, Emname, EmContact, MC, Sport, Skill, Username, Password)
                SELECT RefNo, UserType, Fname, Lname, Gender, Address, Email, Contact, Emname, EmContact, MC, Sport, Skill, Username, Password
                FROM Waiting_List";

                SqlCommand cmdInsert = new SqlCommand(sqlQuery, con);

                SqlCommand cmdDelete = new SqlCommand("Delete FROM Waiting_List WHERE RefNo = @refno", con);
                cmdDelete.Parameters.AddWithValue("@refno", ref_no);

                int rowaffected = cmdInsert.ExecuteNonQuery();
                int i = cmdDelete.ExecuteNonQuery();

                if (rowaffected > 0)
                    status = "Details added sucessfully";
                else
                    status = "Process failed. Please try again";
            }

            else
            {
                status = "User doesn't exist in the waiting list";
            }
 

            return status;
        }

        public string EditProfile(string ref_no, string role, string first_name, string last_name, string gender, string address, string email, string contact, string emn, string emc, string mc, string sport, string skill, string user, string pass)
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
                int i = cmdDelete.ExecuteNonQuery();

                SqlCommand cmdInsert = new SqlCommand("Insert into AllUsers (RefNo, UserType, Fname, Lname, Gender, Address, Email, Contact, Emname, EmContact, MC, Sport, Skill, Username, Password) VALUES (@r, @utype, @f, @l, @g, @a, @em, @c, @emn, @emc, @mc, @s, @skill, @user, @pass)", con);

                cmdInsert.Parameters.AddWithValue("@r", ref_no);
                cmdInsert.Parameters.AddWithValue("@utype", role);
                cmdInsert.Parameters.AddWithValue("@f", first_name);
                cmdInsert.Parameters.AddWithValue("@l", last_name);
                cmdInsert.Parameters.AddWithValue("@g", gender);
                cmdInsert.Parameters.AddWithValue("@a", address);
                cmdInsert.Parameters.AddWithValue("@em", email);
                cmdInsert.Parameters.AddWithValue("@c", contact);
                cmdInsert.Parameters.AddWithValue("@emn", emn);
                cmdInsert.Parameters.AddWithValue("@emc", emc);
                cmdInsert.Parameters.AddWithValue("@mc", mc);
                cmdInsert.Parameters.AddWithValue("@s", sport);
                cmdInsert.Parameters.AddWithValue("@skill", skill);
                cmdInsert.Parameters.AddWithValue("@user", user);
                cmdInsert.Parameters.AddWithValue("@pass", pass);

                int rowaffected = cmdInsert.ExecuteNonQuery();
                if (rowaffected > 0)
                    status = "Edit successful";
                else
                    status = "Edit failed. Please try again";

            }
            else
            {
                status = "User does not exist.";
            }

            con.Close();
            return status;
        }


    }
}
