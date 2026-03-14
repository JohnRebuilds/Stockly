namespace Stockly.Web.Models;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Category { get; set; }
    public string? SKU { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public int MinStockLevel { get; set; }
    public DateTime LastUpdated { get; set; } = DateTime.Now;
}