
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // PART 1: Abstract Class & Polymorphism

        LibraryUtilities.PrintSeparator();
        Console.WriteLine("PART 1: ABSTRACT CLASS");

        LibraryItem item = new Book(1, "Clean Code", 2008, 464);

        item.DisplayInfo();

        Console.WriteLine();

        LibraryItem magazine = new Magazine(
            10, "Technology Today", 2024, 25
        );

        magazine.DisplayInfo();

        Console.WriteLine();

        item.PrintBasicInfo();


        // PART 2: IComparable

        LibraryUtilities.PrintSeparator();
        Console.WriteLine("PART 2: ICOMPARABLE");

        List<Book> books = new List<Book>
        {
            new Book(1, "Clean Code", 2008, 464),
            new Book(2, "The Pragmatic Programmer", 1999, 352),
            new Book(3, "Design Patterns", 1994, 395),
            new Book(4, "C# in Depth", 2019, 900)
        };

        books.Sort();

        foreach (Book book in books)
        {
            Console.WriteLine($"{book.Year} - {book.Title}");
        }


        // PART 3: ICloneable

        LibraryUtilities.PrintSeparator();
        Console.WriteLine("PART 3: ICLONEABLE");

        Book originalBook = new Book(
            5, "Clean Code", 2008, 464
        );

        Book clonedBook = (Book)originalBook.Clone();

        clonedBook.Title = "Clean Code - Copy";

        Console.WriteLine("Original:");
        originalBook.DisplayInfo();

        Console.WriteLine("Clone:");
        clonedBook.DisplayInfo();

        Console.WriteLine(
            "Same Object? " +
            ReferenceEquals(originalBook, clonedBook)
        );


        // PART 4: Static Class

        LibraryUtilities.PrintSeparator();
        Console.WriteLine("PART 4: STATIC CLASS");

        Console.WriteLine(
            "Late Fee: " +
            LibraryUtilities.CalculateLateFee(5)
        );

        Console.WriteLine(
            "Book Code: " +
            LibraryUtilities.GenerateBookCode(15)
        );


        // PART 5: Sealed Class

        LibraryUtilities.PrintSeparator();
        Console.WriteLine("PART 5: SEALED CLASS");

        LibraryCard card = new LibraryCard(
            "CARD-1001",
            "Aya",
            new DateTime(2027, 12, 31)
        );

        card.DisplayCard();

        // LibraryCard is sealed.
        // Therefore, it cannot be inherited.


        // PART 6: Partial Class

        LibraryUtilities.PrintSeparator();
        Console.WriteLine("PART 6: PARTIAL CLASS");

        Book partialBook = new Book(
            20, "C# Programming", 2025, 600
        );

        partialBook.DisplayInfo();
        partialBook.PrintBookDetails();


        // PART 7: Operator Overloading

        LibraryUtilities.PrintSeparator();
        Console.WriteLine("PART 7: OPERATOR OVERLOADING");

        Book book1 = new Book(
            30, "Book One", 2020, 500
        );

        Book book2 = new Book(
            31, "Book Two", 2022, 300
        );

        if (book1 > book2)
        {
            Console.WriteLine("Book 1 has more pages.");
        }

        if (book1 < book2)
        {
            Console.WriteLine("Book 1 has fewer pages.");
        }

        Book combinedBook = book1 + book2;

        Console.WriteLine("Combined Book:");
        combinedBook.DisplayInfo();


        // PART 8: Singleton

        LibraryUtilities.PrintSeparator();
        Console.WriteLine("PART 8: SINGLETON");

        LibraryConfiguration config1 =
            LibraryConfiguration.Instance;

        LibraryConfiguration config2 =
            LibraryConfiguration.Instance;

        Console.WriteLine($"Library: {config1.LibraryName}");

        Console.WriteLine(
            $"Maximum Borrow Days: {config1.MaximumBorrowDays}"
        );

        Console.WriteLine(
            $"Late Fee Per Day: {config1.LateFeePerDay}"
        );

        Console.WriteLine(
            "Same Instance? " +
            ReferenceEquals(config1, config2)
        );


        // END

        LibraryUtilities.PrintSeparator();

        Console.WriteLine("ALL PARTS COMPLETED SUCCESSFULLY!");
    }
}
