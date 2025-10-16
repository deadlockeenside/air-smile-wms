using AirSmileWMS.Domain.Common;
using AirSmileWMS.Domain.ValueObjects;
using System.Security.Cryptography;

namespace AirSmileWMS.Domain.Entities;

public sealed class StockItem : BaseEntity
{
    private Title _title = null!;
    private Text? _text;
    private Amount _monthlyConsumption = null!;
    private Amount _stockBalance = null!;

    // TODO: Image

    public required Title Title 
    { 
        get => _title;
        set => _title = value ?? throw new InvalidDataException(ExceptionMessages.EmptyTitle);
    }

    // TODO: Pieces per package

    public Text? Comment 
    {
        get => _text;
        set => _text = value;
    }

    public required Amount MonthlyConsumption 
    {
        get => _monthlyConsumption;
        set => _monthlyConsumption = value != 0 ? value : throw new InvalidDataException(ExceptionMessages.InvalidAmount);
    }

    public required Amount StockBalance 
    {
        get => _stockBalance;
        set => _stockBalance = value != 0 ? value : throw new InvalidDataException(ExceptionMessages.InvalidAmount);
    }

    public int ReorderQuantity => MonthlyConsumption.Value - StockBalance.Value;
}
