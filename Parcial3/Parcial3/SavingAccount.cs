using System;
using System.Security.Cryptography.X509Certificates;

public class SavingAccount
{
	public SavingAccount : BankAccount
	{
		public double Balance { get; set; }
		public decimal Yield { get; set; }
        public double Deposit()
        { 
        public class Deposit : BankAccount
        }
        public void SavingAccount(int NumberAccount, string Holder, string NameBank, decimal Yield) : BankAccount
        {
        Yield = 0.015;
        }

        public override void Withdraw(double amount, double Balance)
        {
        if (amount > Balance)
        {
            Console.WriteLine("Saldo insuficiente");
            return;
        }
        Balance = Balance - amount;
    }
}
	}
}
