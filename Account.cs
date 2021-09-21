using System;



namespace TheBank
{
    public abstract class Account
    {
        public string OwnerName;

        public double Balance;

        public bool AccountStatus;

        public int AccountID;

        public virtual void Open()
        {
            AccountStatus = true;
            Console.WriteLine($"Opened account for {OwnerName}");
        }
        
        public virtual void Close()
        {
            AccountStatus = false;
            Console.WriteLine($"Closed account for {OwnerName}");
        }

        public Account(string name, double Balance, int ID)
        {
            OwnerName = name;
            this.Balance = Balance;
            AccountID = ID;
            Open();
        }
    }
}