using System;

public class ReceiverNote {

	String sellerName;
	String buyerName;
	int noteNumber;
	int amount;

	public ReceiverNote(String sellerName,
				String buyerName,int noteNumber, int amount)
	{
		this.sellerName = sellerName;
		this.noteNumber = noteNumber;
		this.buyerName = buyerName;
		this.amount = amount;
	}


	public String GetSellerName()
	{
		return sellerName;
	}

	public int GetNoteNumber()
	{
		return noteNumber;
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
		return ("Hello " + this.GetBuyerName() + ", below are the details of your Receiver Note."
				+ ".\nYour Receiver note number is  " + this.GetNoteNumber() + ", and the total amount of the purchase is $"+ this.GetAmount()+ "."
				+ ".\nKind regards " + this.GetSellerName() + ".");
	}

public static void Main(String[] args)
	{

		ReceiverNote Agata = new ReceiverNote("Afeez", "Murphy", 01001, 12000 );
		Console.WriteLine(Agata.ToString());
	}
}