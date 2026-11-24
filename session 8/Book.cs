
using System;

public partial class Book : LibraryItem, IComparable<Book>, ICloneable
{
    public int PageCount { get; set; }

    public Book(int id, string title, int year, int pageCount)
        : base(id, title, year)
    {
        PageCount = pageCount;
    }

    // IComparable implementation
    public int CompareTo(Book? other)
    {
        if (other == null)
            return 1;

        int result = Year.CompareTo(other.Year);

        if (result != 0)
            return result;

        return string.Compare(Title, other.Title, StringComparison.OrdinalIgnoreCase);
    }

    // ICloneable implementation
    public object Clone()
    {
        return new Book(Id, Title, Year, PageCount);
    }

    // Operator >
    public static bool operator >(Book first, Book second)
    {
        return first.PageCount > second.PageCount;
    }

    // Operator <
    public static bool operator <(Book first, Book second)
    {
        return first.PageCount < second.PageCount;
    }

    // Operator +
    public static Book operator +(Book first, Book second)
    {
        return new Book(
            first.Id,
            first.Title + " + " + second.Title,
            first.Year,
            first.PageCount + second.PageCount
        );
    }
}
