using AirSmileWMS.Domain.Common;
using AirSmileWMS.Domain.ValueObjects;

namespace AirSmileWMS.Domain.Entities;

public sealed class StockItem : BaseEntity
{
    private Title _title = null!;
    private Amount _monthlyConsumption = null!;
    private Amount _stockBalance = null!;
    private Capacity _piecesPerPackage = null!;
    private Image _image = null!;

    public required Image Image 
    {
        get => _image;
        set => _image = value ?? throw new InvalidDataException(ExceptionMessages.InvalidImage);
    }

    public required Title Title 
    { 
        get => _title;
        set => _title = value ?? throw new InvalidDataException(ExceptionMessages.EmptyTitle);
    }

    public required Capacity PiecesPerPackage 
    {
        get => _piecesPerPackage;
        set => _piecesPerPackage = value ?? throw new InvalidDataException(ExceptionMessages.InvalidCapacity);
    }

    public Text? Comment { get; set; }

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
