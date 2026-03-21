namespace Stockly.Web.Components.Pages;

public partial class Inventory
{
    [Inject]
    public IProductService ProductService { get; set; } = null!;

    public IReadOnlyList<Product> Products { get; set; } = new List<Product>();
    public ProductKeyPerformanceIndicators KeyPerformanceIndicators { get; set; } = new();
    public ProductQueryParameters Parameters { get; set; } = new();

    protected override async Task OnInitializedAsync()
    {
        await InitializeInventoryDataAsync();
    }

    private async Task InitializeInventoryDataAsync()
    {
        Products = await ProductService.GetProductsAsync(Parameters);
        KeyPerformanceIndicators = await ProductService.GetProductKeyPerformanceDataAsync();
    }

    private async Task RefreshUIAsync()
    {
        Products = await ProductService.GetProductsAsync(Parameters);
        KeyPerformanceIndicators = await ProductService.GetProductKeyPerformanceDataAsync();
    }

    private async Task IncreaseQuantity(Guid productId)
    {
        Product? productToUpdate = await ProductService.GetProductByIdAsync(productId);
        if (productToUpdate is not null)
        {
            await ProductService.IncreaseProductQuantityAsync(productToUpdate);
            await RefreshUIAsync();
        }
    }

    private async Task DecreaseQuantity(Guid productId)
    {
        Product? productToUpdate = await ProductService.GetProductByIdAsync(productId);
        if (productToUpdate is not null)
        {
            await ProductService.DecreaseProductQuantityAsync(productToUpdate);
            await RefreshUIAsync();
        }
    }

    private async Task OnSearchInput(ChangeEventArgs e)
    {
        Parameters = Parameters with { SearchTerm = e.Value?.ToString() ?? "" };
        Products = await ProductService.GetProductsAsync(Parameters);
    }
}