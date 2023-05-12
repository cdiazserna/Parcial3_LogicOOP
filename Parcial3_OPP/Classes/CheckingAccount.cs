using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial3_OPP.Classes
{
    public class CheckingAccount:BankAccount
    {
        public  decimal Credit { get; set; }
        public decimal Overdraft { get; set; } = 0;
        public  double InterestRate { get; set; } = 0;
        public double  WhithDraw{ get; set; } = 0;
        
        
        public void CalculateOverdraft()
        {
            if (Balance < 0)
            {
                Overdraft = Credit * 0.4m;
            }
            else
            {
                Overdraft = 0;
            }
            return
        }
        public void CalculateLatePayment()
        { return}
    }
}
