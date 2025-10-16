using AirSmileWMS.Domain.Entities;

namespace AirSmileWMS.Domain.Interfaces;

public interface IStockItemRepository
{
    IReadOnlyList<StockItem> GetAllLatex();
}
