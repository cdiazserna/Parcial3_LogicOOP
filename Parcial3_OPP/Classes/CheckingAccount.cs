using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Parcial3_OPP.Classes
{
    public class CheckingAccount:BankAccount
    {
        public  decimal Credit { get; set; }
        public decimal Overdraft { get; set; } 
        public  double InterestRate { get; set; } 
        public decimal  WhithDraw{ get; set; }
        public decimal CutoffDate;
        public decimal PaymentDate;



        public decimal CalculateOverdraft( )

           
        { Balance=Credit-WhithDraw;

            if (Balance < 0)
            {
                Overdraft = Credit * 0.4m;
            }
            else
            {
                Overdraft = 0;
            }
            return Overdraft;
        }
        public void CalculateLatePayment()
        { return}
    }
}
