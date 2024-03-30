using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment
{
    internal class User
    {
        // Attributes
        public string Username { get; set; } 
        public string Password { get; set; } 
        public string Role { get; set; } 
        public List<User> UserList { get; set; } 
        public List<User> WaitingList { get; set; } 

        
        public User()
        {
            UserList = new List<User>();
            WaitingList = new List<User>();
            Role = "default role";

        }

        public void Login(string username, string password)
        {
            // Implementation 
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
