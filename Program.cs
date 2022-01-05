using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.User;
using Model.Team;

namespace SE307_Task_Management
{
    class Program
    {
        static List<Team> teams = new List<Team>(); 
        static void Main(string [] args)
        {
            Team.init(teams);
            
            
            User us = new User();
            Team ts = new Team();

            int action = chooseAction();
            while (action != 0)
            {
                Console.WriteLine("You chose :" + action);

                switch (action)
                {
                    //yeni kullanıcı ekliyor
                    case 1:
                        Console.WriteLine( "You choose to add a new User.");                       
                        
                        String UserName = "";
                        String UserTitle = "";
                        String UserAutherization = "";

                        
                        
                        //bool correctInput = false;
                        //while (!correctInput) // this loop will continue until the user enters a number
                        //{
                         //   Console.Write("Enter UserID: ");
                         //   correctInput = int.TryParse(Console.ReadLine(), out UserId); // if the parsing was successful it returns true
                         
                         //   if (!correctInput)
                         //   {
                           //     Console.Write("Your input is must be a number \n");
                         //   }
                        //}
                        //Console.WriteLine("User's id is:");
                        //UserId = int.Parse(Console.ReadLine());


                        Console.WriteLine("What is the User Name :");
                        UserName = Console.ReadLine();
                        if (string.IsNullOrEmpty(UserName))
                        {
                            Console.WriteLine("Name can't be empty! Input your name once more");
                            UserName = Console.ReadLine();
                        }

                        Console.WriteLine("What is the User Title?");
                        UserTitle = Console.ReadLine();

                        Console.WriteLine("What is the User Autherization? Team Member or Team Leader");
                        UserAutherization = Console.ReadLine();

                        /* while (UserAutherization!= "Team Member" || UserAutherization != "Team Leader")
                        {
                            Console.WriteLine("What is the User Autherization? Team Member or Team Leader");
                            UserAutherization = Console.ReadLine(); 

                            if((UserAutherization == "Team Member") || (UserAutherization == "Team Leader"))
                            {
                                Console.WriteLine( "Please check.");
                            }
                            



                        } */
                      

                        
                        User newUser = new User(UserName, UserTitle, UserAutherization);
                        us.UserList.Add(newUser);

                        printUser(us);
                        break;

                        //kullanıcılardan numaraları seçerek aktarma yapıyor
                    case 2:

                        Console.WriteLine("You choose to add user to team.");
                       
                        
                        printUser(us);
                        Console.WriteLine("Which user do you want to add?");
                        int userChosen = int.Parse(Console.ReadLine());

                        us.TeamList.Add(us.UserList[userChosen]);

                        printTeamList(us);
                        break;

                   /* case 3:

                        Console.WriteLine("You choose to add Team Leader.");

                        String UserName1 = "";
                        String UserTitle1 = "";
                        String UserAutherization1 = "Team Leader";


                        Console.WriteLine("What is the User Name :");
                        UserName = Console.ReadLine();
                        if (string.IsNullOrEmpty(UserName))
                        {
                            Console.WriteLine("Name can't be empty! Input your name once more");
                            UserName = Console.ReadLine();
                        }

                        Console.WriteLine("What is the User Title?");
                        UserTitle = Console.ReadLine();

                        User User = new User(UserName1, UserTitle1, UserAutherization1); 
                        us.UserList.Add(User);



                        

                        

                        

                        printTeamLeader(us);
                        break;

                        */
                }
                action = chooseAction();    

            }


            //User u = new User();
            //User u1 = new User(2, "Merve", "Developer", "Team Member");
            //Console.WriteLine("-------Users------" + " " +"User Id  :" +u.UserId +"  "+"User Name :"+ u.Name +"  "+"User Title  :"+ u.Title +" "+ "User Autherization  : "+u.User_Autherization);
            //Console.WriteLine("-------Users------" + " " + "User Id :" + u1.UserId + "  " + "User Name :" + u1.Name + "  " + "User Title :" + u1.Title + "  " + "User Autherization : " + u1.User_Autherization);
            //Console.ReadLine(); 

    
        }

        /* private static void printTeamLeader(User us)
        {
            String UserAutherization1 = "Team Leader";
            Console.WriteLine("New Leader Added..");
            foreach (User us in us)
            {
                Console.WriteLine("User: " + " " + "User ID:" + us.UserId + "  " + "User Name:" + us.Name + "   " + "User Title:" + us.Title + "  " + "User Autherization: " + UserAutherization1);
            }
        }
        */


        private static void printTeamList(User us)
        {
 
            Console.WriteLine("User you have chosen to add.");
            for (int i = 0; i < us.TeamList.Count; i++)
            {
                Console.WriteLine("User: " + " " + us.TeamList[i]);
            }
        }

        private static void printUser(User us)
        {
            for (int i = 0; i < us.UserList.Count; i++ )
            {
                Console.WriteLine("User #: " + i +" "+ us.UserList[i]);
            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action (0) to quit - (1) to add new User - (2) add User to Team - (3) to add Leader");
            choice = int.Parse(Console.ReadLine());
            if(choice != 1 && choice!=2 && choice != 3)
            {
                Console.WriteLine("Error.. You check again your action..");
            }
            

            return choice;
        }
    }
}
