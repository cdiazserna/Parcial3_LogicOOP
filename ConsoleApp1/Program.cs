using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositoinicial;
            int numberAccount;
            string holder, nameBank;

            Console.WriteLine("----------------------------");
            Console.WriteLine("DATOS BANCARIOS");
            Console.WriteLine("----------------------------");

            BankAccount bankAccount = new BankAccount();

            SavingAccount savingAccount = new SavingAccount();

            CheckingAccount checkingAccount = new CheckingAccount();

            Console.Write("Ingrese el nombre del titular de la cuenta: ");
            numberAccount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el nombre del titular de la cuenta: ");
            holder= Console.ReadLine();

            Console.Write("Ingrese el nombre del banco: ");
            nameBank = Console.ReadLine();
        

            Console.WriteLine("Ingrese el valor que depositó el banco en su cuenta de ahorros");
            depositoinicial = Convert.ToDouble(Console.ReadLine());

     

   

        }
    }
}
