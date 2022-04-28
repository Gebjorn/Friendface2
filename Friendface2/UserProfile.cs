using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    internal class UserProfile
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public int Age { get; private set; }
        public string Description { get; private set; }
        public string Hobbies { get; private set; }
        public int ID { get; private set; }

        public List<UserProfile> ListofFriends { get; private set; }




        public UserProfile(string username, string password, int age, string description, string hobbies, int id)
        {
            Username = username;
            Password = password;
            Age = age;
            Description = description;
            Hobbies = hobbies;
            ID = id;
            ListofFriends = new List<UserProfile>();
        }

        public void AddFriend(UserProfile userProfile)
        {
            ListofFriends.Add(userProfile);
        }

        public void RemoveFriend(UserProfile userprofile)
        {
            ListofFriends.Remove(userprofile);
        }

        public void PrintAllFriends()
        {
            foreach (var user in ListofFriends)
            {
                System.Console.WriteLine($" ID: {user.ID} Username: {user.Username} Age: {user.Age}");
            }
        }

    }
}
