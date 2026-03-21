namespace Stockly.Web.Models;

public record ProductKeyPerformanceIndicators(int ProductCount = 0, decimal InventoryValue = 0, int LowStockProductCount = 0);
