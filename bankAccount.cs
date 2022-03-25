using System;

public class BankAccount {

	String name;
	decimal balance;
	String country;
	String cardType;

	public BankAccount(String name, decimal balance,
				String country, String cardType)
	{
		this.name = name;
		this.balance = balance;
		this.country = country;
		this.cardType = cardType;
	}

	public String GetName()
	{
		return name;
	}

	public decimal GetBalance()
	{
		return balance;
	}

	public String GetCountry()
	{
		return country;
	}

	public String GetCardType()
	{
		return cardType;
	}

	public String ToString()
	{
		return ("Hi your name is " + this.GetName()
				+ ".\nYou are from " + this.GetCountry()
				+ " your account balance is $" + this.GetBalance() + " and your card-type is " + this.GetCardType() + ".");
	}

public static void Main(String[] args)
	{

		BankAccount Santandar = new BankAccount("Afeez", 5000, "Poland", "Debit Card");
		Console.WriteLine(Santandar.ToString());
	}
}