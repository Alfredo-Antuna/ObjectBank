using System;



namespace TheBank
{
    


    public abstract class Account{


        public  string OwnerName;

        public int Balance;

        public bool AccountStatus;

        public int AccountID;


        public virtual void Open(){ AccountStatus = true; }
        //TODO maybe do these virtual
        public virtual void Close(){AccountStatus = false;}

        public Account(string name, int Balance){
            OwnerName = name;
            this.Balance = Balance;
            Open();
            
        }

    }
}