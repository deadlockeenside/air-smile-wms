using AirSmileWMS.Domain.Common;
using AirSmileWMS.Domain.ValueObjects;

namespace AirSmileWMS.Domain.Entities;

public sealed class StockItem : BaseEntity
{
    private Title _title = null!;
    private Text? _text;

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

    // TODO: Monthly consumption
    // TODO: Stock balance
    // TODO: Reorder quantity (calculated as: monthly consumption − stock balance)
}
