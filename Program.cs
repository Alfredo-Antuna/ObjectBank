using System;
using System.Collections.Generic;



namespace TheBank
{
    class Program
    {
        static void Main(string[] args)
        {   
            //List<User> initList = new List<User>();

            TheBank MyBank = new TheBank();

            MyBank.AddNewUser("Steve");
            
            //MyBank.UserList[0].addAccount(10000, true, MyBank.IndexNewID());

            int newAccountID = MyBank.MakeAccountForUser("Steve", 10000, true);
            Console.WriteLine($"New account ID: {newAccountID}");

            int failedAccountID = MyBank.MakeAccountForUser("Beth", 10000, true);

            User steve = MyBank.GetUserReference("Steve");

            double forecast = (steve.getAccountWithID(newAccountID) as SavingsAcct).Forecast(3);
            Console.WriteLine($"In 3 years, Steve's savings account will have: ${forecast}");

            MyBank.UserList[0].addAccount(10, false, MyBank.IndexNewID());
            CheckingAcct checkingAcct1 = MyBank.UserList[0].Accounts[1] as CheckingAcct;
            checkingAcct1.Deposit(50);
            checkingAcct1.Withdraw(10);
            checkingAcct1.Withdraw(70);
            checkingAcct1.Deposit(250);
            // checkingAcct1.Withdraw(500);
            // checkingAcct1.Withdraw(500);

            checkingAcct1.ShowTransactionLogs();
        }
    }
}
