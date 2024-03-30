using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Policy;
namespace IOOP_assignment
{
    internal class User
    {
        // Attributes
        public string Username { get; set; } 
        public string Password { get; set; } 
        public string Role { get; set; } 
       

        
        public User()
        {
      

        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;  
        }

        public User(string username, string password, string role) 
        {
            this.Role = role;
            Username = username;
            Password = password;
           
        }

        public string Login(string username, string password)
        {
            string status = null;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from AllUsers where RefNo=@a and password =@p", con);
            cmd.Parameters.AddWithValue("@a", username);
            cmd.Parameters.AddWithValue("@p", password);


            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("select role from AllUsers where RefNo =@a and password =@p", con);
                cmd2.Parameters.AddWithValue("@a", username);
                cmd2.Parameters.AddWithValue("@p", password);

                string userRole = cmd2.ExecuteScalar().ToString();

                if (userRole == "Admin")
                {
                    Admin_Menu admin_Menu = new Admin_Menu();
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

        public void SignUp(string username, string password, string role)
        {
            // Implementation
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
