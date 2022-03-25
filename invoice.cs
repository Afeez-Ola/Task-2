using System;

public class Invoice {

	String sellerName;
	String buyerName;
	int invoiceNumber;
	int amount;

	public Invoice(String sellerName,
				String buyerName,int invoiceNumber, int amount)
	{
		this.sellerName = sellerName;
		this.invoiceNumber = invoiceNumber;
		this.buyerName = buyerName;
		this.amount = amount;
	}


	public String GetSellerName()
	{
		return sellerName;
	}

	public int GetInvoiceNumber()
	{
		return invoiceNumber;
	}

	public String GetBuyerName()
	{
		return buyerName;
	}
	
	public int GetAmount()
	{
		return amount;
		
	}

	public String ToString()
	{
		return ("Hello " + this.GetBuyerName() + ", below are the details of your invoice."
				+ ".\nYour invoice number is  " + this.GetInvoiceNumber() + ", and the total amount of the purchase is $"+ this.GetAmount()+ "."
				+ ".\nKind regards " + this.GetSellerName() + ".");
	}

public static void Main(String[] args)
	{

		Invoice Agata = new Invoice("Afeez", "Murphy", 21, 12000 );
		Console.WriteLine(Agata.ToString());
	}
}