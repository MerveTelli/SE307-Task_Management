using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SE307_Task_Management;
using Model.Team;

namespace Model.User
{
    public class User
    {
        
        private static int counter = 1;
        protected internal int UserId { get; }
        public String Name { get; set; }
        public String Title { get; set; }
        public String User_Autherization { get; set; }
        public List<User> UserList { get; set; }
        public List<User> TeamList { get; set; }

        public User ()
        {
            UserId = counter;
            Name = "";
            Title = "";
            User_Autherization = "";
            UserList = new List<User>();
            TeamList = new List<User>();           

            counter++;

        }


       

        public User(string name, string title, string user_Autherization)
        {
           
            UserId = counter;
            Name = name;
            Title = title;
            User_Autherization = user_Autherization;

            counter++;
        }

        public override string ToString()
        {
            return "User ID:" + UserId + "  " + "User Name:" + Name + "   " + "User Title:" + Title+ "  " + "User Autherization:" + User_Autherization;
        }




    }
}
