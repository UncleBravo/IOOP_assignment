using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Policy;
using System.Runtime.InteropServices;
namespace IOOP_assignment
{
    internal class User
    {
        // Attributes
      
        public string RefNo { get; set; }
        public string UserName { get; set; }
        public string role { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string name { get; set; }
        public string Contact { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public string EmergencyName { get; set; }

        public string EmergencyContact { get; set; }

        public string MedicalCondition { get; set; }

        public string Sport { get; set; }

        public string Skill { get; set; }



        public User()
        {
         

        }

        public User(string refno, string password)
        {
            RefNo = refno;
            Password = password;  
        }

        public User(string ref_no, string role, string first_name, string last_name, string gender, string address, string email, string contact, string emn, string emc, string mc, string sport, string skill, string user, string pass)
        {
            RefNo = ref_no;
            this.role = role;
            FirstName = first_name;
            LastName = last_name;
            Gender = gender;
            Address = address;
            Email = email;
            Contact = contact;
            EmergencyName = emn;
            EmergencyContact = emc;
            MedicalCondition = mc;
            Sport = sport;
            Skill = skill;
            UserName = user;
            Password = pass;

        }
        public string Login()
        {
            string status = null;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from AllUsers where RefNo=@a and password =@p", con);
            cmd.Parameters.AddWithValue("@a", RefNo);
            cmd.Parameters.AddWithValue("@p", Password);


            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("select UserType from AllUsers where RefNo =@a and password =@p", con);
                cmd2.Parameters.AddWithValue("@a", RefNo);
                cmd2.Parameters.AddWithValue("@p", Password);

                string userRole = cmd2.ExecuteScalar().ToString();

                if (userRole == "Admin")
                {
                    Admin_Menu admin_Menu = new Admin_Menu(RefNo);
                    admin_Menu.Show();
                }

                else if (userRole == "Coach")
                {
                    Coach_Menu coach_Menu = new Coach_Menu();
                    coach_Menu.Show();

                }

                else if (userRole == "Manager")
                {
                    Manager_Menu manager_Menu = new Manager_Menu();
                    manager_Menu.Show();

                }
                else if (userRole == "Member")
                {
                    Member_Form member_Form = new Member_Form();
                    member_Form.Show();
                }
            }
            else
                status = "Incorrect username/password.";  
            con.Close();
            return status;
        }

        public string Signup(string ref_no, string role, string first_name, string last_name, string gender, string address, string email, string contact, string emn, string emc, string mc, string sport, string skill, string user, string pass)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) from AllUsers where RefNo=@username", con);
            cmdCheck.Parameters.AddWithValue("@username", ref_no);

            int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
            if (count > 0)
                status = "User always exists";
            else
            {
                SqlCommand cmdInsert = new SqlCommand("Insert into Waiting_List (RefNo, UserType, Fname, Lname, Gender, Address, Email, Contact, Emname, EmContact, MC, Sport, Skill, Username, Password) VALUES (@r, @utype, @f, @l, @g, @a, @em, @c, @emn, @emc, @mc, @s, @skill, @user, @pass)", con);

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
                    status = "Sign up successful";
                else
                    status = "Sign up failed";
            }

            con.Close();
            return status;
        }

        public void ViewUserList(User user)
        {
            // Implementation 
        }
        public void ViewWaitingList(User user)
        {
            // Implementation 
        }
        public void UpdateProfile(string newUsername, string newPassword)
        {
            // Implementation 
        }




    }
}
