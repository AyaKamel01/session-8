
using System;

public static class LibraryUtilities
{
    public static double CalculateLateFee(int overdueDays)
    {
        if (overdueDays <= 0)
            return 0;

        return overdueDays * LibraryConfiguration.Instance.LateFeePerDay;
    }

    public static string GenerateBookCode(int id)
    {
        return $"BOOK-{id:D5}";
    }

    public static void PrintSeparator()
    {
        Console.WriteLine("==============================");
    }
}
