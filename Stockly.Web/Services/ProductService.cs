namespace Stockly.Web.Services;

public class ProductService : IProductService
{
    private readonly ApplicationDbContext _context;

    public ProductService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<Product>> GetAllProductsAsync()
    {
        var products = await _context.Products.ToListAsync();
        return products.AsReadOnly();
    }

    public async Task<IReadOnlyList<Product>> GetProductsAsync(ProductQueryParameters parameters)
    {
        var query = _context.Products.AsQueryable();

        if (!string.IsNullOrEmpty(parameters.Filter))
        {
            string filterToLower = parameters.Filter.ToLower();
            query = query.Where(x => x.Name.ToLower().Contains(filterToLower) || (!string.IsNullOrEmpty(x.SKU) && x.SKU.ToLower().Contains(filterToLower)));
        }

        var products = await query.ToListAsync();
        return products.AsReadOnly();
    }

    public async Task<Product?> GetProductByIdAsync(Guid id)
    {
        var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
        return product;
    }

    public async Task<ProductKeyPerformanceIndicators> GetProductKeyPerformanceDataAsync()
    {
        var products = await GetAllProductsAsync();

        int productCount = products.Count;
        decimal inventoryValue = products.Sum(x => x.Quantity * x.Price);

        var lowStockProducts = products.Where(x => x.Quantity <= x.MinStockLevel);
        int lowStockProductCount = lowStockProducts.Count();

        return new ProductKeyPerformanceIndicators(productCount, inventoryValue, lowStockProductCount);
    }

    public async Task IncreaseProductQuantityAsync(Product product)
    {
        product.Quantity++;

        _context.Update(product);
        await _context.SaveChangesAsync();
    }

    public async Task DecreaseProductQuantityAsync(Product product)
    {
        if (product.Quantity > 0)
        {
            product.Quantity--;
            _context.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}