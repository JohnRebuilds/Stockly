namespace Stockly.Web.Services;

public interface IProductService
{
    public IReadOnlyList<Product> GetAllProducts();
    public IReadOnlyList<Product> GetProducts(string filter = "");
    public Product? GetProductById(Guid id);
    public ProductKeyPerformanceIndicators GetProductKeyPerformanceData();
    public void IncreaseProductQuantity(Product product);
    public void DecreaseProductQuantity(Product product);
}
