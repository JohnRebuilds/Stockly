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
        var products = _dataProvider.Get();
        if (products is null)
        {
            return Array.Empty<Product>();
        }

        return products;
    }

    public IReadOnlyList<Product> GetProducts(string filter = "")
    {
        var query = _dataProvider.GetAsQueryable();

        if (!string.IsNullOrEmpty(filter))
        {
            query = query.Where(x => x.Name.Contains(filter, StringComparison.OrdinalIgnoreCase) || x.SKU.Contains(filter, StringComparison.OrdinalIgnoreCase));
        }

        return query.ToList().AsReadOnly();
    }

    public Product? GetProductById(Guid id)
    {
        var product = _dataProvider.GetById(id);
        return product;
    }

    public ProductKeyPerformanceIndicators GetProductKeyPerformanceData()
    {
        var products = GetProducts();

        int productCount = products.Count;
        decimal inventoryValue = products.Sum(x => x.Quantity * x.Price);

        var lowStockProducts = products.Where(x => x.Quantity <= x.MinStockLevel);
        int lowStockProductCount = lowStockProducts.Count();

        return new ProductKeyPerformanceIndicators(productCount, inventoryValue, lowStockProductCount);
    }

    public void IncreaseProductQuantity(Product product)
    {
        product.Quantity++;
    }

    public void DecreaseProductQuantity(Product product)
    {
        if (product.Quantity > 0)
        {
            product.Quantity--;
        }
    }
}