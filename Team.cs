using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.User;

namespace Model.Team
{
    public class Team

       
    {
        public static void init(List<Team> teams)
        {
            teams.Add(new Team("Team-1",""));
            teams.Add(new Team("Team-2",""));


           
        }

        



        public static int counter = 1;
        public int TeamId { get; set; }
        public String TeamName { get; set; }
        public String TeamLeader { get; set; }
        

        

        public Team()
        {
            TeamId = counter;
            TeamName = "nothing yet";
            TeamLeader = "nothing yet";

            counter++;
        }

        

        public Team(string name, string leader)
        {

            TeamId = counter;
            TeamName = name;
            TeamLeader = leader;

            counter++;
            
        }
    }

}
