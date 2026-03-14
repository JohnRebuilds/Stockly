namespace Stockly.Web.Components.Pages;

public partial class Inventory
{
    [Inject]
    public IProductService ProductService { get; set; } = null!;

    public IReadOnlyList<Product> Products { get; set; } = null!;

    public int TotalProductCount { get; set; }

    protected override void OnInitialized()
    {
        Products = ProductService.GetAllProducts();
        TotalProductCount = ProductService.GetTotalProductCount();
    }
}