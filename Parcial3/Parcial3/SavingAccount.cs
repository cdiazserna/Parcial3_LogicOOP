using System;

public class SavingAccount:BankAccount
{
	public decimal Balance { get; set; }
	public decimal Yield { get; set; }

	public void Deposit ()
	{
		

	}
	public void WithDraw ()
	{

	}
	public void Tranfer()
	{

	}
	public decimal CalculateYield()
	{
		return Yield;
	}
}
