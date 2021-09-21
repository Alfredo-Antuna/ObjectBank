using System;
using System.Collections.Generic;

namespace TheBank
{
    public class TheBank{

        private List<User> userList;

        private int lastID = 0;

        public int indexNewID()
        {
            lastID++;
            return lastID;
        }

        public TheBank()
        {
            userList = new List<User>();
        }

        public void addNewUser(string userName)
        {
            userList.Add(new User(userName));
        }

        public int makeAccountForUser(string userName, double initialBalance, bool isSavings)
        {
            foreach(User someUser in userList)
            {
                if (someUser.name == userName)
                {
                    int newId = this.indexNewID();
                    someUser.addAccount(initialBalance, isSavings, newId);
                    return newId;
                }
            }

            Console.WriteLine($"A user does not exist with the name {userName}");

            return -1;
        }

        public User getUserReference(string userName)
        {
            foreach(User someUser in userList)
            {
                if (someUser.name == userName)
                {
                    return someUser;
                }
            }

            return null;
        }
    }
}