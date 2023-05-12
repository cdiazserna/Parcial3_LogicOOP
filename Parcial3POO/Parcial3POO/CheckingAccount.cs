using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Parcial3POO
{
    public class CheckingAccount : BankAccount
    {

        public decimal Credit { get; set; }
        public decimal Overdraft { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRite { get; } = 0.0265m;
    }

    public Deposit()
    {
        Holder = holder;
        NameBank = nameBack;
        Credit = credit;
        Overdraft = credit * 0.4m;
    }

    public void Withdraw(decimal amount)
    {


    }

    public double CalculateOverdraft() 
    {
    
    }

    public double CalculateLatePayment()
    {

    }
}
