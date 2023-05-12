using Parcial3;
using System;
using System.Security.Cryptography.X509Certificates;

public class SavingsAccount : BankAccount
{
    public double Yield { get; private set; }

    public SavingsAccount(string number, string holder, string nameBank, double balance)
        : base(number, holder, nameBank, balance)
    {
        Yield = 0;
    }

    public void CalculateYields()
    {
        Yield = Balance * 0.015;
    }

    public void Transfer(BankAccount destination, double amount)
    {
        if (amount <= Balance)
        {
            Withdraw(amount);
            destination.Deposit(amount);
        }
    }
}