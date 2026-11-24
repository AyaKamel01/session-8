
using System;

public sealed class LibraryCard
{
    public string CardNumber { get; set; }
    public string MemberName { get; set; }
    public DateTime ExpirationDate { get; set; }

    public LibraryCard(
        string cardNumber,
        string memberName,
        DateTime expirationDate)
    {
        CardNumber = cardNumber;
        MemberName = memberName;
        ExpirationDate = expirationDate;
    }

    public void DisplayCard()
    {
        Console.WriteLine("Library Card Information:");
        Console.WriteLine($"Card Number: {CardNumber}");
        Console.WriteLine($"Member Name: {MemberName}");
        Console.WriteLine($"Expiration Date: {ExpirationDate:dd/MM/yyyy}");
    }
}
