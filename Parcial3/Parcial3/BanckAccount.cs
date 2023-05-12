using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Parcial3
{
    public class BanckAccount
    {

        public int NumberAccount { get; set; }
        public string Holder { get; set; }
        public string NameBanck { get; set; }

        public decimal Deposit(decimal amount)
        {
            return amount;
        }
            public virtual decimal Withdraw()
        {
         
        }

    }
}
