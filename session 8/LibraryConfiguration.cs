
using System;

public sealed class LibraryConfiguration
{
    private static readonly Lazy<LibraryConfiguration> _instance =
        new Lazy<LibraryConfiguration>(
            () => new LibraryConfiguration()
        );

    private LibraryConfiguration()
    {
        LibraryName = "My Library";
        MaximumBorrowDays = 14;
        LateFeePerDay = 5.0;
    }

    public static LibraryConfiguration Instance => _instance.Value;

    public string LibraryName { get; set; }

    public int MaximumBorrowDays { get; set; }

    public double LateFeePerDay { get; set; }
}
