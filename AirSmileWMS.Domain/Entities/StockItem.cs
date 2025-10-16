using AirSmileWMS.Domain.Common;
using AirSmileWMS.Domain.ValueObjects;

namespace AirSmileWMS.Domain.Entities;

public sealed class StockItem : BaseEntity
{
    // TODO: Image
    public required Title Title { get; set; }
    // TODO: Pieces per package
    // TODO: Stock item comment
    // TODO: Monthly consumption
    // TODO: Stock balance
    // TODO: Reorder quantity (calculated as: monthly consumption − stock balance)
}
