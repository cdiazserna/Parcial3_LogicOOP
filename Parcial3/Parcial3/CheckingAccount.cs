using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

public class CheckingAccount
{
	public CheckingAccount : BankAccount
	{
        public double Credit { get; set; }
        public double Overdraft { get; set; }
        public double InterestRate { get; set; }

    public CheckingAccount(string NumberAccount, string Holder, string NameBank, double credit) : BankAccount
    {
        
        Credit = 1000;
        Credit = credit;
        Overdraft = 0.4 * credit;
        InterestRate = 0.0265;
    }
       
        public decimal Deposit()
            {
               
            }
        public void Withdraw(double amount, double Balance)
        {
        if (amount > Balance + Overdraft)
        {
            Console.WriteLine("Fondos insuficientes");
            return;
        }
        if (amount <= Balance)
        {
            Balance = Balance - amount;
        }
        else
        {
            double overdraftUsado= amount - Balance;
            Balance = 0.0;
            Overdraft = Overdraft - overdraftUsado;
        }
        public void CalculateOverdraft()
        {
            Console.WriteLine($"Tu limite de sobrecupo es: {Overdraft:C}");
        }

        public double CalculateLatePayment(DateTime dueDate)
        {
            int daysLate = (int)(DateTime.Today - dueDate).TotalDays;
            if (daysLate > 0)
            {
                return Balance * InterestRate * daysLate;
            }
            return 0.0;
        }
    }
}
