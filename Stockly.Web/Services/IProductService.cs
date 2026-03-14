namespace Stockly.Web.Services;

public interface IProductService
{
    public IReadOnlyList<Product> GetAllProducts();
    public Product? GetProductById(Guid id);
    public int GetTotalProductCount();
}
