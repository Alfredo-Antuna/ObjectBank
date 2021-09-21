using System;
using System.Collections.Generic;



namespace TheBank
{
    class Program
    {
        static void Main(string[] args)
        {   
            TheBank myBank = new TheBank();

            myBank.addNewUser("Steve");
            
            int newAccountId1 = myBank.makeAccountForUser("Steve", 10000, true);
            Console.WriteLine($"New account ID: {newAccountId1}");

            int failedAccountId = myBank.makeAccountForUser("Beth", 10000, true);

            User steve = myBank.getUserReference("Steve");

            double forecast = (steve.getAccountWithId(newAccountId1) as SavingsAcct).forecast(3);
            Console.WriteLine($"In 3 years, Steve's savings account will have: ${forecast}");

            int newAccountId2 = myBank.makeAccountForUser("Steve", 10, false);
            Console.WriteLine($"New account ID: {newAccountId2}");

            CheckingAcct checkingAcct1 = steve.getAccountWithId(newAccountId2) as CheckingAcct;
            checkingAcct1.deposit(50);
            checkingAcct1.withdraw(10);
            checkingAcct1.withdraw(70);
            checkingAcct1.deposit(250);

            checkingAcct1.showTransactionLogs();
        }
    }
}
