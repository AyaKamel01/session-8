
using System;

public abstract class LibraryItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }

    protected LibraryItem(int id, string title, int year)
    {
        Id = id;
        Title = title;
        Year = year;
    }

    public abstract void DisplayInfo();

    public void PrintBasicInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Year: {Year}");
    }
}
