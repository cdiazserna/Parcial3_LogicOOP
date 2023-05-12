using System;

namespace Parcial3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberAccount=0;
            string holder= " ", nameBank=" ";
            decimal credit=0, overDraft=0, balance=0, yield=0;
            float interestRate=0;

            BankAccount bankAccount = new BankAccount
            {
                NumberAccount = numberAccount,
                Holder = holder,
                NameBank = nameBank,
            };
            CheckingAccount checkingAccount = new CheckingAccount
            {
                Credit = credit,
                OverDraft= overDraft,
                InterestRate= interestRate,
            };
            SavingAccount savingAccount = new SavingAccount
            {
                Balance= balance,
                Yield= yield,
            };

            Console.WriteLine("\n***************   Banco   ******************\n");
            Console.WriteLine(" Ingresa Por Favor Nombre Del Banco\n");
            nameBank=Console.ReadLine();
            Console.WriteLine("\n Ingresa Por Favor el Nombre \n");
            holder=Console.ReadLine();
            Console.WriteLine(" \n Ingresa Por Favor el Numero de Cuenta \n");
            numberAccount= Convert.ToInt32(Console.ReadLine());


        }
    }
}
