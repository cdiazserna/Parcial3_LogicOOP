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
        public double depositoinicial;
        public double Deposit()
        {
            Console.WriteLine("Ingrese el valor que depositó el banco en su cuenta");
            depositoinicial= Convert.ToDouble(Console.ReadLine());
            return depositoinicial;
        }

        public decimal Withdraw()
        {
            return Withdraw();
        }


    }
}
