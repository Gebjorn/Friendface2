using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    internal class Friendface
    {
        public List<UserProfile> ListofUsers { get; private set; }
        public UserProfile Admin { get; private set; }
        public Friendface()
        {
            Admin = new UserProfile("Geir", "123abc", 29, "Chief", "Bossing", 0);

            ListofUsers = new List<UserProfile>()
            {
                new UserProfile("Elisabeth", "mittpassordja", 27, "Giver of cakes.", "Unicorns, baking, sewing.", 1),
                new UserProfile("Anniken", "EnHjøRnInGeRbEsT", 4, "Maker of mess.", "Unicorns, playing, running.", 2),
                new UserProfile("Terje", "terje", 00, "Terjer of Terjes.", "Coding, chess, Terje.", 3),
                new UserProfile("Bjørnar", "bjørn", 00, "Teacher of nerds.", "Joking, riddles, kahoots.", 4)
            };
        }
        public void DashboardText()
        {
            Console.WriteLine("Velkommen til FriendFace, det nyeste kule sosiale mediet som tar verden med storm!");
            Console.WriteLine();
            Console.WriteLine("Hovedmeny:");
            Console.WriteLine("1: Legg til venner");
            Console.WriteLine("2: Fjern venner!");
            Console.WriteLine("3: Vis venner");
            Console.WriteLine("4: Vis utvalgt venn");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    int userID = PrintAllUsers();
                    Console.WriteLine();
                    UserProfile userProfile = GetUserProfileFromId(userID);
                    Admin.AddFriend(userProfile);
                    Console.WriteLine();
                    break;
                //Legg til venner
                case "2":
                    Admin.PrintAllFriends();
                    Console.WriteLine();
                    userID = Convert.ToInt32(Console.ReadLine());
                    userProfile = GetUserProfileFromId(userID);
                    Admin.RemoveFriend(userProfile);
                    Console.WriteLine();
                    break;
                //Fjern venner
                case "3":
                    Admin.PrintAllFriends();
                    Console.WriteLine();
                    //Vis venner
                    break;
                case "4":
                    Admin.PrintAllFriends();
                    Console.WriteLine();
                    userID = Convert.ToInt32(Console.ReadLine());
                    userProfile = GetUserProfileFromId(userID);
                    PrintOutUser(userProfile);
                    Console.WriteLine();
                    //Vis utvalgt venn
                    break;
            }
        }
        public void PrintOutUser(UserProfile user)
        {
            System.Console.WriteLine($" ID: {user.ID} Username: {user.Username} Age: {user.Age} Description: {user.Description} Hobbies: {user.Hobbies}");

        }

        public int PrintAllUsers()
        {
            foreach (var user in ListofUsers)
            {
                PrintOutUser(user);
            }
            int userID = Convert.ToInt32(Console.ReadLine());
            return userID;
        }
        public UserProfile GetUserProfileFromId(int userID)
        {
            var user = ListofUsers.Where(user => user.ID == userID).First();
            return user;
        }
    }
}
