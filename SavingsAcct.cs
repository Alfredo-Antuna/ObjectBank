using System;



namespace TheBank
{


    public class SavingsAcct : Account
     {
             public float InterestRate = .012f;



            public override void Open(){

            }
            public override void Close(){

            }


            public float Forecast(float years){
                
                return (Balance * (float)(Math.Pow((1 +(InterestRate/12)),(12*years))));
                


            }
            public SavingsAcct(string acctName ,int initialBalance):base(acctName,initialBalance){

            }


    }



}