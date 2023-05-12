using System;

public class CheckingAccount:BankAccount
{
    public int credit { get; set; }
    private int totalDeposit { get; set; }
    public string interestRate { get; set; }
    public string overDraft { get; set; }
    public int cashWithdrawn { get; set; }
    public int balance { get; set; }



    public void deposit()
    {
        
        Console.WriteLine("Ingrese la cuenta del titular a depositar \n");
        numberAccount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese El monto a depositar \n");
        totalDeposit = Convert.ToInt32(Console.ReadLine());
    }

    public decimal withDraw()
    {
        Console.WriteLine("Ingrese la cantidad de dinero a retirar \n");
        cashWithdrawn = Convert.ToInt32(Console.ReadLine());
        totalDeposit = totalDeposit - cashWithdrawn;

        return totalDeposit;
    }

    public void calculateOverdraft()
    {
        to
    }

    public void calculateLatePayment()
    {

    }
}
