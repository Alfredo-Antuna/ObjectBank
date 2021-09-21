using System;

namespace TheBank
{
    public class SavingsAcct : Account
    {
        public double interestRate = .012f;

        public SavingsAcct (string acctName, double initialBalance, int id) : base(acctName, initialBalance, id)
        {
            Console.WriteLine($"{acctName} opened a savings account.");
        }

        public double forecast (double years)
        {
            double futureBalance = (balance * (double)(Math.Pow((1 + (interestRate / 12)), (12 * years))));
            futureBalance = Math.Round(futureBalance, 2);
            return futureBalance;
        }
    }
}