using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class BankAccount
    {
        public int NumberAccount { get; set; }
        public string Holder { get; set; }
        public string NameBank { get; set; }
        public double Depositoinicial { get; set; }
        public double saldoretirado { get; set; }
        public double Deposit()
        {
            return Depositoinicial;
        }

        public decimal Withdraw()
        {
            if (Deposit() > saldoretirado)
            {

            }

            return Withdraw();
        }

        
    }
}
