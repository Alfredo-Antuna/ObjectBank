using System;



namespace TheBank
{
    public abstract class Account
    {
        protected string ownerName;

        protected double balance;

        protected bool accountStatus;

        public int accountId;

        public virtual void open()
        {
            accountStatus = true;
            Console.WriteLine($"Opened account for {ownerName}");
        }
        
        public virtual void close()
        {
            accountStatus = false;
            Console.WriteLine($"Closed account for {ownerName}");
        }

        public Account(string name, double initialBalance, int id)
        {
            ownerName = name;
            balance = initialBalance;
            accountId = id;
            open();
        }
    }
}