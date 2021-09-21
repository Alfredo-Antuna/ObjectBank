using System;
using System.Collections.Generic;



namespace TheBank
{

    public class User{


        public string Name;
        public List<Account> Accounts;


        public User(string myName){
            
            Name = myName;
            Accounts = new List<Account>();
        }

        public void addAccount(int initialBalance, bool isSavings){

            

        }
    }


}