
using System;

public partial class Book
{
    public override void DisplayInfo()
    {
        Console.WriteLine("Book Information:");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Pages: {PageCount}");
    }

    public void PrintBookDetails()
    {
        Console.WriteLine("----------------------");
        Console.WriteLine($"Book: {Title}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Pages: {PageCount}");
        Console.WriteLine("----------------------");
    }
}
