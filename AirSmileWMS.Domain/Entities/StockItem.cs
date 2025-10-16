using AirSmileWMS.Domain.Common;
using AirSmileWMS.Domain.ValueObjects;

namespace AirSmileWMS.Domain.Entities;

public sealed class StockItem : BaseEntity
{
    private Title _title = null!;

    // TODO: Image

    public required Title Title 
    { 
        get => _title;
        set => _title = value ?? throw new InvalidDataException(ExceptionMessages.EmptyTitle);
    }

    // TODO: Pieces per package
    // TODO: Stock item comment
    // TODO: Monthly consumption
    // TODO: Stock balance
    // TODO: Reorder quantity (calculated as: monthly consumption − stock balance)
}
