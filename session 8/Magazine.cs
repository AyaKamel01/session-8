
using System;

public class Magazine : LibraryItem
{
    public int IssueNumber { get; set; }

    public Magazine(int id, string title, int year, int issueNumber)
        : base(id, title, year)
    {
        IssueNumber = issueNumber;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Magazine Information:");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Issue Number: {IssueNumber}");
    }
}
