namespace Stockly.Web.Services;

public class ProductService : IProductService
{
    private readonly List<Product> _products = new();

    public ProductService()
    {
        _products.AddRange(new List<Product>
        {
            new Product { Id = Guid.NewGuid(), Name = "Vägguttag 2-vägs Jordat", Category = "Elartiklar", SKU = "EL-VU-2J", Price = 149.00m, Quantity = 45, MinStockLevel = 10 },
            new Product { Id = Guid.NewGuid(), Name = "Strömbrytare Trapp/Infälld", Category = "Elartiklar", SKU = "EL-SB-TR", Price = 129.00m, Quantity = 30, MinStockLevel = 8 },
            new Product { Id = Guid.NewGuid(), Name = "Installationskabel EKK 3G1.5 50m", Category = "Kabel", SKU = "KB-EKK-50", Price = 895.00m, Quantity = 4, MinStockLevel = 5 },
            new Product { Id = Guid.NewGuid(), Name = "Automatsäkring 10A C-kar", Category = "Elcentral", SKU = "MCB-10C", Price = 55.00m, Quantity = 100, MinStockLevel = 20 },
            new Product { Id = Guid.NewGuid(), Name = "LED-Panel 60x60 4000K", Category = "Belysning", SKU = "LED-P60", Price = 699.00m, Quantity = 12, MinStockLevel = 4 },
            new Product { Id = Guid.NewGuid(), Name = "Rörelsevakt 180° IP44", Category = "Belysning", SKU = "SEN-PIR180", Price = 349.00m, Quantity = 7, MinStockLevel = 3 },
            new Product { Id = Guid.NewGuid(), Name = "Kopplingsdosa Vit", Category = "Elartiklar", SKU = "EL-KD-V", Price = 29.00m, Quantity = 150, MinStockLevel = 50 },
            new Product { Id = Guid.NewGuid(), Name = "Dimmer LED 5-250W", Category = "Elartiklar", SKU = "EL-DIM-LED", Price = 499.00m, Quantity = 10, MinStockLevel = 5 },
            new Product { Id = Guid.NewGuid(), Name = "VP-Rör 16mm 3m", Category = "Installation", SKU = "VP-16-3M", Price = 25.00m, Quantity = 80, MinStockLevel = 30 },
            new Product { Id = Guid.NewGuid(), Name = "Flexslang m. Fördragen FK 3G1.5", Category = "Kabel", SKU = "FX-FK315", Price = 1195.00m, Quantity = 2, MinStockLevel = 3 },
            new Product { Id = Guid.NewGuid(), Name = "Gräsklippare Batteridriven", Category = "Trädgårdsmaskiner", SKU = "GK-B40", Price = 4299.00m, Quantity = 5, MinStockLevel = 2 },
            new Product { Id = Guid.NewGuid(), Name = "Trimmertråd 2.4mm 15m", Category = "Trädgårdstillbehör", SKU = "TT-2415", Price = 89.00m, Quantity = 25, MinStockLevel = 10 },
            new Product { Id = Guid.NewGuid(), Name = "Häcksax Pro", Category = "Trädgårdsmaskiner", SKU = "HS-PRO70", Price = 1850.00m, Quantity = 3, MinStockLevel = 2 },
            new Product { Id = Guid.NewGuid(), Name = "Sekatör Classic", Category = "Trädgårdsredskap", SKU = "SK-CL", Price = 249.00m, Quantity = 15, MinStockLevel = 5 },
            new Product { Id = Guid.NewGuid(), Name = "Grensåg Teleskop", Category = "Trädgårdsredskap", SKU = "GS-TEL", Price = 599.00m, Quantity = 8, MinStockLevel = 3 },
            new Product { Id = Guid.NewGuid(), Name = "Batteri 18V 5Ah", Category = "Trädgårdstillbehör", SKU = "BAT-18V5", Price = 899.00m, Quantity = 12, MinStockLevel = 4 },
            new Product { Id = Guid.NewGuid(), Name = "Lövblås Akku", Category = "Trädgårdsmaskiner", SKU = "LB-180", Price = 1295.00m, Quantity = 2, MinStockLevel = 2 },
            new Product { Id = Guid.NewGuid(), Name = "Planteringsspade", Category = "Trädgårdsredskap", SKU = "PS-RED", Price = 49.00m, Quantity = 40, MinStockLevel = 10 },
            new Product { Id = Guid.NewGuid(), Name = "Gräsmattegödsel 10kg", Category = "Kemi & Skötsel", SKU = "GG-10KG", Price = 329.00m, Quantity = 20, MinStockLevel = 5 },
            new Product { Id = Guid.NewGuid(), Name = "Slangvinda 20m", Category = "Bevattning", SKU = "SV-20", Price = 749.00m, Quantity = 6, MinStockLevel = 2 },
            new Product { Id = Guid.NewGuid(), Name = "Träskruv 4,5x60mm", Category = "Fästelement", SKU = "TS-4560", Price = 89.00m, Quantity = 450, MinStockLevel = 100 },
            new Product { Id = Guid.NewGuid(), Name = "Vattenpass 60cm", Category = "Mätverktyg", SKU = "VP-60", Price = 349.00m, Quantity = 12, MinStockLevel = 3 },
            new Product { Id = Guid.NewGuid(), Name = "Hammare 16oz", Category = "Handverktyg", SKU = "HM-16", Price = 199.00m, Quantity = 25, MinStockLevel = 5 },
            new Product { Id = Guid.NewGuid(), Name = "Bitsset 32 delar", Category = "Tillbehör", SKU = "BS-32", Price = 129.00m, Quantity = 40, MinStockLevel = 10 },
            new Product { Id = Guid.NewGuid(), Name = "Måttband 5m", Category = "Mätverktyg", SKU = "MB-5", Price = 79.00m, Quantity = 60, MinStockLevel = 15 },
            new Product { Id = Guid.NewGuid(), Name = "Arbetshandske Stl 10", Category = "Skydd", SKU = "AH-10", Price = 45.00m, Quantity = 120, MinStockLevel = 30 },
            new Product { Id = Guid.NewGuid(), Name = "Skruvdragare 18V", Category = "Elverktyg", SKU = "SD-18V", Price = 1299.00m, Quantity = 8, MinStockLevel = 2 },
            new Product { Id = Guid.NewGuid(), Name = "Fogmassa Vit", Category = "Kemi", SKU = "FM-V", Price = 65.00m, Quantity = 35, MinStockLevel = 10 },
            new Product { Id = Guid.NewGuid(), Name = "Penselset 3-pack", Category = "Måleri", SKU = "PS-3", Price = 119.00m, Quantity = 18, MinStockLevel = 5 },
            new Product { Id = Guid.NewGuid(), Name = "Sandpapper K120", Category = "Slip", SKU = "SP-120", Price = 12.00m, Quantity = 200, MinStockLevel = 50 }

        });
    }

    public IReadOnlyList<Product> GetAllProducts()
    {
        if (_products is null)
        {
            return Array.Empty<Product>();
        }
        else
        {
            return _products.AsReadOnly();
        }
    }

    public Product? GetProductById(Guid id) => _products.FirstOrDefault(x => x.Id == id);
}
