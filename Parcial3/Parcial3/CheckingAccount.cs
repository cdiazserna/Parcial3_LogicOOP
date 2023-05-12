using System;

public class CheckingAccount : BankAccount
{
	public decimal Credit { get; set; }
	public decimal OverDraft { get; set; }
	public float InterestRate { get; set; }
	
	public void Deposit ()
	{

	}
	public void WithDraw ()
	{

	}
	public decimal	CalculateOverDraft ()
	{
		return Credit;
	}
	public decimal CalculateLatePayment ()
	{
		return OverDraft; 
	}
}
