using System;
using System.Security.Cryptography.X509Certificates;

public class CheckingAccount
{
	public CheckingAccount : BankAccount
	{

        public decimal Credit { get; set; }
        public decimal Overdraft { get; set; }
        public decimal InterestRate { get; set; }
        public decimal Deposit()
        public decimal Withdraw()
        public decimal CalculateOverdraft()
        public decimal CalculateLatePayment()
    }
}
