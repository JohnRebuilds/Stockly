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

    public IReadOnlyList<Product> FilterProducts(string filter)
    {
        var products = _dataProvider.GetAll();

        if (products is null)
        {
            return Array.Empty<Product>();
        }

        IQueryable<Product> query = products.AsQueryable();

        query = query.Where(x => x.Name.Contains(filter) || x.SKU.Contains(filter));

        return query.ToList().AsReadOnly();
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