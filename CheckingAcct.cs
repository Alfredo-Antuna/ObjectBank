using System;
using System.Collections.Generic;



namespace TheBank
{


    public class CheckingAcct : Account
     {
             public int InfractionCounter;

             public List<string> History;

            public override void Open(){

            }
            public override void Close(){

            }

             public CheckingAcct(string acctName ,int initialBalance):base(acctName,initialBalance){
                 History = new List<string>();
                 InfractionCounter = 0;
                

            }

            //increase balance
            //add to hist
            public void Deposit(int amount){
                Balance += amount;
                History.Add($"{OwnerName}, 03/04/2021, Deposit, ${amount}, Success, ${Balance}");
                Console.WriteLine($"{OwnerName}, 03/04/2021, Deposit, ${amount}, Success, ${Balance}");
            }   

                //decrease balance
                //check if sufficient
                //50 fee if statement
                    //increase infraction counter if statement
                    //if infraction counter 3 if statement
                //update history
            public bool Withdraw(int amount){
                if(Balance >= amount)
                {
                    Balance -= amount;
                    History.Add($"{OwnerName}, 03/04/2021, Withdraw, ${amount}, Success, ${Balance}");
                    Console.WriteLine($"{OwnerName}, 03/04/2021, Withdraw, ${amount}, Success, ${Balance}");
                    return true;

                }else
                {  
                    History.Add($"{OwnerName}, 03/04/2021, Withdraw, ${amount}, Failed, ${Balance}");
                    Console.WriteLine($"{OwnerName}, 03/04/2021, Withdraw, ${amount}, Failed, ${Balance}");
                    InfractionCounter++;
                    if(InfractionCounter==3){this.Close();}
                    

                    return false;
                }
                

            }


            public void ShowTransactionLogs(){
                //Console.WriteLine(Stuff)
            }





    }



}