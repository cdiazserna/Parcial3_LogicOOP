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

        public void MostrarResultados()
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("Resultados:{0}");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

            Console.WriteLine("Titular de la cuenta: {0}");

            Console.WriteLine("Banco: {0}");

            Console.WriteLine("Cuenta corriente:{0}");
            Console.WriteLine("Crédito inicial aprobado: {0}");
            Console.WriteLine("Saldo actual: {0}");
            Console.WriteLine("Sobregiro: {0}");
            Console.WriteLine("Interés en mora: {0}");

            Console.WriteLine("Cuenta de ahorros:{0}");
            Console.WriteLine("Saldo: {0}");
        }
    }
}
