namespace Stockly.Web.Components.Pages;

public partial class Inventory
{
    [Inject]
    public IProductService ProductService { get; set; } = null!;

    public IReadOnlyList<Product> Products { get; set; } = null!;
    public ProductKeyPerformanceIndicators KeyPerformanceIndicators { get; set; } = null!;

    private string? _searchTerm;

    public string? SearchTerm 
    { 
        get
        {
            return _searchTerm;
        } 
        set
        {
           _searchTerm = value;

            if (!string.IsNullOrWhiteSpace(_searchTerm)) Products = ProductService.FilterProducts(_searchTerm);
            else Products = ProductService.GetAllProducts();

            KeyPerformanceIndicators = ProductService.GetProductKeyPerformanceData();
        }
    }

    protected override void OnInitialized()
    {
        LoadInventoryData();
    }

    private void IncreaseQuantity(Guid productId)
    {
        Product? productToUpdate = ProductService.GetProductById(productId);
        if (productToUpdate is not null)
        {
            ProductService.IncreaseProductQuantity(productToUpdate);
            LoadInventoryData();
        }
    }

    private void DecreaseQuantity(Guid productId)
    {
        Product? productToUpdate = ProductService.GetProductById(productId);
        if (productToUpdate is not null)
        {
            ProductService.DecreaseProductQuantity(productToUpdate);
            LoadInventoryData();
        }
    }

    private void LoadInventoryData()
    {
        Products = ProductService.GetAllProducts();
        KeyPerformanceIndicators = ProductService.GetProductKeyPerformanceData();
    }
}