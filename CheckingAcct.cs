using System;
using System.Collections.Generic;



namespace TheBank
{
    public class CheckingAcct : Account
    {
        public int infractionCounter;

        public List<string> history;

        public CheckingAcct(string acctName, double initialBalance, int id) : base(acctName, initialBalance, id)
        {
            history = new List<string>();
            infractionCounter = 0;

            string reciept = $"{acctName}, 03/04/2021, Initial Deposit, ${initialBalance}, Success, Balance: ${balance}";

            history.Add(reciept);
            
            Console.WriteLine($"{acctName} opened a checking account");
        }

        //increase balance
        //add to hist
        public void deposit(int amount)
        {
            if (!accountStatus)
            {
                Console.WriteLine("Sorry, this account is closed.");
                return;
            }
            
            balance += amount;

            string reciept = $"{ownerName}, 03/04/2021, Deposit, ${amount}, Success, Balance: ${balance}";

            history.Add(reciept);
        }   

        //decrease balance
        //check if sufficient
        //50 fee if statement
        //increase infraction counter if statement
        //if infraction counter 3 if statement
        //update history
        public bool withdraw(int amount)
        {
            if (!accountStatus)
            {
                Console.WriteLine("Sorry, this account is closed.");
                return false;
            }

            if (balance >= amount)
            {
                balance -= amount;

                string reciept = $"{ownerName}, 03/04/2021, Withdraw, ${amount}, Success, Balance: ${balance}";

                history.Add(reciept);

                return true;
            }
            else
            {
                string reciept = $"{ownerName}, 03/04/2021, Withdraw, ${amount}, Failed, Balance: ${balance}";

                history.Add(reciept);

                balance -= 50;

                string feeReciept = $"{ownerName}, 03/04/2021, Fee, ${50}, Success, Balance: ${balance}";

                history.Add(feeReciept);

                infractionCounter++;

                if (infractionCounter == 3)
                {
                    history.Add("Maximum infractures acrrued. The account is now closed.");
                    this.close();
                }

                return false;
            }
        }

        public void showTransactionLogs()
        {
            Console.WriteLine("Your transactions:");

            foreach(string log in history)
            {
                Console.WriteLine(log);
            }
        }
    }
}