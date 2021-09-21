using System;
using System.Collections.Generic;

namespace TheBank
{
    public class User
    {
        public string Name;
        public List<Account> Accounts;

        public User(string myName){
            
            Name = myName;
            Accounts = new List<Account>();
        }

        public void addAccount(double initialBalance, bool isSavings, int ID)
        {
            if(isSavings)
            {
                Accounts.Add(new SavingsAcct(Name, initialBalance, ID));
            }
            else
            {
                Accounts.Add(new CheckingAcct(Name, initialBalance, ID));
            }
        }

        public Account getAccountWithID(int ID)
        {
            foreach(Account acc in Accounts)
            {
                if (ID == acc.AccountID)
                {
                    return acc;
                }
            }

            return null;
        }
    }
}