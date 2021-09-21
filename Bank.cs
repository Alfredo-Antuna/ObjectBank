using System;
using System.Collections.Generic;

namespace TheBank
{
    public class TheBank{

        public List<User> UserList;

        public int lastID = 0;

        public int IndexNewID()
        {
            lastID++;
            return lastID;
        }

        public TheBank()
        {
            UserList = new List<User>();
        }

        public void AddNewUser(string userName)
        {
            UserList.Add(new User(userName));
        }

        public int MakeAccountForUser(string userName, double initialBalance, bool isSavings)
        {
            foreach(User someUser in UserList)
            {
                if (someUser.Name == userName)
                {
                    int newID = this.IndexNewID();
                    someUser.addAccount(initialBalance, isSavings, newID);
                    return newID;
                }
            }

            Console.WriteLine($"A user does not exist with the name {userName}");

            return -1;
        }

        public User GetUserReference(string userName)
        {
            foreach(User someUser in UserList)
            {
                if (someUser.Name == userName)
                {
                    return someUser;
                }
            }

            return null;
        }
    }
}