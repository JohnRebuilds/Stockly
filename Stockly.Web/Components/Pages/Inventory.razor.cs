namespace Stockly.Web.Components.Pages;

public partial class Inventory
{
    [Inject]
    public IProductService ProductService { get; set; } = null!;

    public IReadOnlyList<Product> Products { get; set; } = new List<Product>();
    public ProductKeyPerformanceIndicators KeyPerformanceIndicators { get; set; } = new(0, 0, 0);

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
            //Products = ProductService.GetProducts(_searchTerm ?? "");
        }
    }

    protected override async Task OnInitializedAsync()
    {
        await LoadInventoryDataAsync();
    }

    private async Task LoadInventoryDataAsync()
    {
        Products = await ProductService.GetAllProductsAsync();
        KeyPerformanceIndicators = await ProductService.GetProductKeyPerformanceDataAsync();
    }

    private async Task IncreaseQuantity(Guid productId)
    {
        Product? productToUpdate = await ProductService.GetProductByIdAsync(productId);
        if (productToUpdate is not null)
        {
            await ProductService.IncreaseProductQuantityAsync(productToUpdate);
            await LoadInventoryDataAsync();
        }
    }

    private async Task DecreaseQuantity(Guid productId)
    {
        Product? productToUpdate = await ProductService.GetProductByIdAsync(productId);
        if (productToUpdate is not null)
        {
            await ProductService.DecreaseProductQuantityAsync(productToUpdate);
            await LoadInventoryDataAsync();
        }
    }
}