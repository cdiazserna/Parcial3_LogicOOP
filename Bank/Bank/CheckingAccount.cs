using System;

public class CheckingAccount:BankAccount
{
    public decimal credit { get; set; }//
    public float interestRate { get; set; } //
    public decimal overDraft { get; set; }//
    public decimal cashWithdrawn { get; set; }//
    public int daysLate { get; set; }//
    public decimal card { get; set; }



    public void deposit()
    {
        
        Console.WriteLine("Ingrese la cuenta del titular del credito \n");
        numberAccount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese El monto del credito \n");
        credit = Convert.ToInt32(Console.ReadLine());
    }

    public void withDraw()
    {
        Console.WriteLine("Ingrese la cantidad de dinero a retirar \n");
        cashWithdrawn = Convert.ToDecimal(Console.ReadLine());
        credit = credit - cashWithdrawn;
    }

    public decimal calculateOverdraft()

    {
        overDraft = credit * (decimal)interestRate;
        return overDraft;
    }

    public decimal calculateLatePayment()
    {
        return daysLate * (decimal)(interestRate);
    }


    public void creditCard()
    {
        Console.WriteLine("Ingrese el monto de la compra de la tarjeta");
        card = Convert.ToDecimal(Console.ReadLine());
        credit = credit - card;
    }
}
