using System;

public class SavingAccount:BankAccount
{
    public int yield { get; set; }
    public decimal balance{ get; set; }
    public decimal cashWithdrawn { get; set; }
    public decimal trasfers { get; set; }
    public int moths { get; set; }


    public void deposit()
    {
        Console.WriteLine("Ingrese la cuenta del titular del credito \n");
        numberAccount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese El monto del credito \n");
        balance = Convert.ToInt32(Console.ReadLine());
    }

    public void withdraw()
    {
        Console.WriteLine("Ingrese la cantidad de dinero a retirar \n");
        cashWithdrawn = Convert.ToDecimal(Console.ReadLine());
        balance = balance - cashWithdrawn;
    }

    public void trasfer()
    {
        Console.WriteLine("Ingrese la cantidad a traferir \n");
        trasfers = Convert.ToDecimal(Console.ReadLine());
        balance = balance - trasfers;
    }

    public decimal calculateYield()
    {
        return moths * yield;
    }
}
