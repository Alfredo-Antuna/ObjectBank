using System;

namespace TheBank
{
    public class SavingsAcct : Account
    {
        public double InterestRate = .012f;

        public SavingsAcct(string acctName, double initialBalance, int ID) : base(acctName, initialBalance, ID)
        {
            Console.WriteLine($"{acctName} opened a savings account.");
        }

        public double Forecast (double years)
        {
            double futureBalance = (Balance * (double)(Math.Pow((1 +(InterestRate/12)),(12*years))));
            futureBalance = Math.Round(futureBalance, 2);
            return futureBalance;
        }
    }
}