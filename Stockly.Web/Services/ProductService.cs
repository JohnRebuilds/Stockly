namespace Stockly.Web.Services;

public class ProductService : IProductService
{
    private readonly DataProvider _dataProvider;

    public ProductService(DataProvider dataProvider)
    {
        _dataProvider = dataProvider;
    }

    public IReadOnlyList<Product> GetAllProducts()
    {
        var products = _dataProvider.GetAll();

        if (products is null)
        {
            return Array.Empty<Product>();
        }
        else
        {
            return products;
        }
    }

    public Product? GetProductById(Guid id)
    {
        var product = _dataProvider.GetById(id);
        return product;
    }

    public ProductKeyPerformanceIndicators GetProductKeyPerformanceData()
    {
        var products = GetAllProducts();

        int productCount = products.Count;
        decimal inventoryValue = products.Sum(x => x.Quantity * x.Price);

        var lowStockProducts = products.Where(x => x.Quantity <= x.MinStockLevel);
        int lowStockProductCount = lowStockProducts.Count();

        return new ProductKeyPerformanceIndicators(productCount, inventoryValue, lowStockProductCount);
    }

    public void IncreaseProductQuantity(Product product) => product.Quantity++;
    public void DecreaseProductQuantity(Product product) => product.Quantity--;
}
