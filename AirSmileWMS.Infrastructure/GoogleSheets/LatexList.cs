namespace AirSmileWMS.Infrastructure.GoogleSheets;

internal static class LatexList
{
    public const string Name = "Латекс";
    public const string UseRange = $"{Name}!B2:H";
    public const byte ApproximateRowsCount = 40;
    public const byte Image = 0;
    public const byte Id = 1;
    public const byte Title = 2;
    public const byte PiecesPerPackage = 3;
    public const byte StockItemComment = 4;
    public const byte MonthlyConsumption = 5;
    public const byte StockBalance = 6;
}
