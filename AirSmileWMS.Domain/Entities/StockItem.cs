using AirSmileWMS.Domain.Common;
using AirSmileWMS.Domain.ValueObjects;

namespace AirSmileWMS.Domain.Entities;

public sealed class StockItem : BaseEntity
{
    private Title _title = null!;
    private Text? _text;
    private Amount _monthlyConsumption = null!;
    private Amount _stockBalance = null!;
    private Capacity _piecesPerPackage = null!;

    // TODO: Image

    public required Title Title 
    { 
        get => _title;
        set => _title = value ?? throw new InvalidDataException(ExceptionMessages.EmptyTitle);
    }

    public Capacity PiecesPerPackage 
    {
        get => _piecesPerPackage;
        set => _piecesPerPackage = value ?? throw new InvalidDataException(ExceptionMessages.InvalidCapacity);
    }

    public Text? Comment 
    {
        get => _text;
        set => _text = value;
    }

    public required Amount MonthlyConsumption 
    {
        get => _monthlyConsumption;
        set => _monthlyConsumption = value ?? throw new InvalidDataException(ExceptionMessages.InvalidAmount);
    }

    public required Amount StockBalance 
    {
        get => _stockBalance;
        set => _stockBalance = value ?? throw new InvalidDataException(ExceptionMessages.InvalidAmount);
    }

    public int ReorderQuantity => MonthlyConsumption.Value - StockBalance.Value;
}
