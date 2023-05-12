using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class CheckingAccount : BankAccount
    {
        public int Credit { get; set; }
        public int Overdraft { get; set; }
        public double InterestRate { get; set; }
        public int DiasPagoAtrasado;
        public int saldoinicialcuenta = 1000100;
        public double CalculateOverdraft()
        {
            return Credit * 0.40;
        }
        public double CalculateLatePayment()
        {
            if (DiasPagoAtrasado > 0)
            {
                InterestRate = Credit * 0.0265;
            }
            return InterestRate;
        }
    }
}
