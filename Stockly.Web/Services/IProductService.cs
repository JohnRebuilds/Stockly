namespace Stockly.Web.Services;

public interface IProductService
{
    public Task<IReadOnlyList<Product>> GetAllProductsAsync();
    public Task<IReadOnlyList<Product>> GetProductsAsync(ProductQueryParameters parameters);
    public Task<Product?> GetProductByIdAsync(Guid id);
    public Task<ProductKeyPerformanceIndicators> GetProductKeyPerformanceDataAsync();
    public Task IncreaseProductQuantityAsync(Product product);
    public Task DecreaseProductQuantityAsync(Product product);
}
