using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial3
{
    public class CheckingAccount : BanckAccount
    {
        public decimal Credit { get; set; }
        public decimal Overdraft { get; set; }
        public double InterestRate { get; set; }

        public decimal Deposit(decimal amount)
        {
            return base.Deposit(amount);
        }
        public decimal Withdraw()
        {
            return;
        }

        public decimal CalculateOverdraft()
        {
            return;
        }

        public decimal CalculateLatePayment()
        {
            return;
        }

    }
}
