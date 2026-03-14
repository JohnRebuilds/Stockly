namespace Stockly.Web.Components.Pages;

public partial class Inventory
{
    [Inject]
    public IProductService ProductService { get; set; } = null!;

    public IReadOnlyList<Product> Products { get; set; } = null!;
    public ProductKeyPerformanceIndicators KeyPerformanceIndicators { get; set; } = null!;


    protected override void OnInitialized()
    {
        Products = ProductService.GetAllProducts();
        KeyPerformanceIndicators = ProductService.GetProductKeyPerformanceData();
    }
}