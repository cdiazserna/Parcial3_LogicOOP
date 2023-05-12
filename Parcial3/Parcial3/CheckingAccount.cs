using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial3
{
    public class CheckingAccount : BankAccount
    {
        public decimal Credit { get; set; }
        public decimal Overdraft { get; set; }
        public decimal InterestRate { get; set; }

        public decimal Deposit(decimal amount)
        {
            return base.Deposit(amount);
        }
        public decimal Withdraw(decimal amount)
        {
            return base.Withdraw(amount);
        }

        public decimal CalculateOverdraft()
        {
            return Credit *0.4M;
        }

        public decimal CalculateLatePayment(int daysLate)
        {
            return Credit * (0.0265m * daysLate);
        }

    }
}
