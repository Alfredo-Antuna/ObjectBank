using System;
using System.Collections.Generic;

namespace TheBank
{
    public class User
    {
        public string name;
        public List<Account> accounts;

        public User(string myName)
        {
            name = myName;
            accounts = new List<Account>();
        }

        public void addAccount(double initialBalance, bool isSavings, int id)
        {
            if (isSavings)
            {
                accounts.Add(new SavingsAcct(name, initialBalance, id));
            }
            else
            {
                accounts.Add(new CheckingAcct(name, initialBalance, id));
            }
        }

        public Account getAccountWithId(int id)
        {
            foreach(Account acc in accounts)
            {
                if (id == acc.accountId)
                {
                    return acc;
                }
            }

            return null;
        }
    }
}