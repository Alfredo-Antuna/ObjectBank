using System;
using System.Collections.Generic;



namespace TheBank
{
    public class CheckingAcct : Account
    {
        public int InfractionCounter;

        public List<string> History;

        public CheckingAcct(string acctName, double initialBalance, int ID) : base(acctName, initialBalance, ID)
        {
            History = new List<string>();
            InfractionCounter = 0;

            string reciept = $"{acctName}, 03/04/2021, Initial Deposit, ${initialBalance}, Success, Balance: ${Balance}";

            History.Add(reciept);
            //Console.WriteLine(reciept);
            
            Console.WriteLine($"{acctName} opened a checking account");
        }

        //increase balance
        //add to hist
        public void Deposit(int amount)
        {
            if (!AccountStatus)
            {
                Console.WriteLine("Sorry, this account is closed.");
                return;
            }
            
            Balance += amount;

            string reciept = $"{OwnerName}, 03/04/2021, Deposit, ${amount}, Success, Balance: ${Balance}";

            History.Add(reciept);
            //Console.WriteLine(reciept);
        }   

        //decrease balance
        //check if sufficient
        //50 fee if statement
        //increase infraction counter if statement
        //if infraction counter 3 if statement
        //update history
        public bool Withdraw(int amount)
        {
            if (!AccountStatus)
            {
                Console.WriteLine("Sorry, this account is closed.");
                return false;
            }

            if (Balance >= amount)
            {
                Balance -= amount;

                string reciept = $"{OwnerName}, 03/04/2021, Withdraw, ${amount}, Success, Balance: ${Balance}";

                History.Add(reciept);
                //Console.WriteLine(reciept);

                return true;
            }
            else
            {
                string reciept = $"{OwnerName}, 03/04/2021, Withdraw, ${amount}, Failed, Balance: ${Balance}";

                History.Add(reciept);
                //Console.WriteLine(reciept);

                Balance -= 50;

                string feeReciept = $"{OwnerName}, 03/04/2021, Fee, ${50}, Success, Balance: ${Balance}";

                History.Add(feeReciept);
                //Console.WriteLine(feeReciept);

                InfractionCounter++;

                if (InfractionCounter == 3)
                {
                    History.Add("Maximum infractures acrrued. The account is now closed.");
                    // Console.WriteLine("Maximum infractures acrrued. Closing account...");
                    this.Close();
                }

                return false;
            }
        }

        public void ShowTransactionLogs()
        {
            Console.WriteLine("Your transactions:");

            foreach(string log in History)
            {
                Console.WriteLine(log);
            }
        }
    }
}