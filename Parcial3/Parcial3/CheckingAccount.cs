using Parcial3;
using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

public class CheckingAccount : BankAccount
{
    public double Credit { get; set; }
    public double Overdraft { get; private set; }
    public double InterestRate { get; set; }

    public CheckingAccount(string number, string holder, string nameBank, double credit)
        : base(number, holder, nameBank, 0)
    {
        Credit = credit;
        Overdraft = credit * 0.4;
        InterestRate = 0.0265;
    }
    public void CalculateOverdraft()
    {
        Console.WriteLine("Tu límite de sobrecupo es: {Overdraft:C}");
    }

    public override string ToString()
    {
        return ("Checking Account:\n{base.ToString()}\nCredit: {Credit:C}\nOverdraft: {Overdraft:C}\nInterestRate: {InterestRate:P}\n");
    }
}

