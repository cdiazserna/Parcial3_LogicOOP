using System;

public class CheckingAccount:BankAccount
{
    public int credit { get; set; }
    private decimal totalDeposit { get; set; }
    public string interestRate { get; set; }
    public string overDraft { get; set; }
    public decimal cashWithdrawn { get; set; }
    public int daysLate { get; set; }



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
        cashWithdrawn = Convert.ToDecimal(Console.ReadLine());
        //balance = balance - cashWithdrawn;

        return cashWithdrawn;
    }

    public decimal calculateOverdraft()
    {
        return totalDeposit *(decimal)0.4;
    }

    public decimal calculateLatePayment()
    {
        return daysLate * (decimal)(2.65 / 100);
    }
}
