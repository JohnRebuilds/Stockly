namespace Stockly.Web.Data;

/// <summary>
/// Ansvarar för att populera databasen med initial testdata vid applikationens start.
/// Används för att säkerställa en konsekvent utvecklingsmiljö med ett representativt sortiment.
/// </summary>
public static class DataLoader
{
    /// <summary>
    /// Kontrollerar om databastabellen för produkter är tom. 
    /// Om tabellen saknar poster läggs 100 fördefinierade produkter till 
    /// inom kategorierna Bygg, El, Trädgård, Färg och VVS.
    /// </summary>
    /// <param name="context">Applikationens databaskontext (EF Core).</param>
    public static void Load(ApplicationDbContext context)
    {
        if (!context.Products.Any())
        {
            var products = new List<Product>
            {
                // VERKTYG & BYGG (20 st)
                new Product { Id = Guid.NewGuid(), Name = "Borrhammare SDS-Plus 800W", Category = "VERKTYG & BYGG", SKU = "VB-BH-800", Price = 1895m, Quantity = 12, MinStockLevel = 3 },
                new Product { Id = Guid.NewGuid(), Name = "Skruvdragare 18V Borstlös", Category = "VERKTYG & BYGG", SKU = "VB-SD-18B", Price = 2450m, Quantity = 25, MinStockLevel = 5 },
                new Product { Id = Guid.NewGuid(), Name = "Cirkelsåg 190mm 1600W", Category = "VERKTYG & BYGG", SKU = "VB-CS-190", Price = 1490m, Quantity = 8, MinStockLevel = 2 },
                new Product { Id = Guid.NewGuid(), Name = "Vattenpass Magnet 120cm", Category = "VERKTYG & BYGG", SKU = "VB-VP-120", Price = 599m, Quantity = 15, MinStockLevel = 4 },
                new Product { Id = Guid.NewGuid(), Name = "Hammare Ergonomisk 16oz", Category = "VERKTYG & BYGG", SKU = "VB-HM-16", Price = 249m, Quantity = 40, MinStockLevel = 10 },
                new Product { Id = Guid.NewGuid(), Name = "Hylsnyckelsats 94 delar", Category = "VERKTYG & BYGG", SKU = "VB-HS-94", Price = 1295m, Quantity = 10, MinStockLevel = 3 },
                new Product { Id = Guid.NewGuid(), Name = "Vinkelslip 125mm 900W", Category = "VERKTYG & BYGG", SKU = "VB-VS-125", Price = 795m, Quantity = 14, MinStockLevel = 4 },
                new Product { Id = Guid.NewGuid(), Name = "Kombistegar 3x3 meter", Category = "VERKTYG & BYGG", SKU = "VB-KS-33", Price = 2100m, Quantity = 6, MinStockLevel = 2 },
                new Product { Id = Guid.NewGuid(), Name = "Fogsvans 550mm Proffs", Category = "VERKTYG & BYGG", SKU = "VB-FS-550", Price = 189m, Quantity = 35, MinStockLevel = 8 },
                new Product { Id = Guid.NewGuid(), Name = "Laserpass Grön Stråle 360", Category = "VERKTYG & BYGG", SKU = "VB-LP-360", Price = 3800m, Quantity = 4, MinStockLevel = 1 },
                new Product { Id = Guid.NewGuid(), Name = "Tving Snabbgrepp 300mm", Category = "VERKTYG & BYGG", SKU = "VB-TV-300", Price = 145m, Quantity = 50, MinStockLevel = 12 },
                new Product { Id = Guid.NewGuid(), Name = "Multiverktyg 300W Sladd", Category = "VERKTYG & BYGG", SKU = "VB-MV-300", Price = 995m, Quantity = 18, MinStockLevel = 5 },
                new Product { Id = Guid.NewGuid(), Name = "Gipshiss 3.5m Maxhöjd", Category = "VERKTYG & BYGG", SKU = "VB-GH-35", Price = 2250m, Quantity = 3, MinStockLevel = 1 },
                new Product { Id = Guid.NewGuid(), Name = "Arbetsbock Stabil Alu", Category = "VERKTYG & BYGG", SKU = "VB-AB-ALU", Price = 450m, Quantity = 20, MinStockLevel = 5 },
                new Product { Id = Guid.NewGuid(), Name = "Stämjärnsset 4 delar", Category = "VERKTYG & BYGG", SKU = "VB-SJ-04", Price = 399m, Quantity = 22, MinStockLevel = 6 },
                new Product { Id = Guid.NewGuid(), Name = "Klyvsåg Bord 2000W", Category = "VERKTYG & BYGG", SKU = "VB-KY-200", Price = 4900m, Quantity = 2, MinStockLevel = 1 },
                new Product { Id = Guid.NewGuid(), Name = "Betongblandare 120L", Category = "VERKTYG & BYGG", SKU = "VB-BB-120", Price = 3450m, Quantity = 5, MinStockLevel = 2 },
                new Product { Id = Guid.NewGuid(), Name = "Måttband 8m Autolock", Category = "VERKTYG & BYGG", SKU = "VB-MB-08", Price = 129m, Quantity = 60, MinStockLevel = 15 },
                new Product { Id = Guid.NewGuid(), Name = "Bitsset Impact 32 delar", Category = "VERKTYG & BYGG", SKU = "VB-BS-32", Price = 295m, Quantity = 45, MinStockLevel = 10 },
                new Product { Id = Guid.NewGuid(), Name = "Slagskruvdragare 1/4\" 18V", Category = "VERKTYG & BYGG", SKU = "VB-SS-18", Price = 2150m, Quantity = 12, MinStockLevel = 3 },

                // EL OCH INSTALLATION (20 st)
                new Product { Id = Guid.NewGuid(), Name = "Vägguttag Jordat 2-vägs", Category = "EL OCH INSTALLATION", SKU = "EL-VU-2V", Price = 89m, Quantity = 120, MinStockLevel = 30 },
                new Product { Id = Guid.NewGuid(), Name = "Strömbrytare Trapp/Enpol", Category = "EL OCH INSTALLATION", SKU = "EL-SB-TR", Price = 75m, Quantity = 85, MinStockLevel = 25 },
                new Product { Id = Guid.NewGuid(), Name = "FK-Kabel 1.5mm2 Blå 100m", Category = "EL OCH INSTALLATION", SKU = "EL-FK-15B", Price = 450m, Quantity = 15, MinStockLevel = 5 },
                new Product { Id = Guid.NewGuid(), Name = "FK-Kabel 1.5mm2 Brun 100m", Category = "EL OCH INSTALLATION", SKU = "EL-FK-15BR", Price = 450m, Quantity = 14, MinStockLevel = 5 },
                new Product { Id = Guid.NewGuid(), Name = "FK-Kabel 1.5mm2 G/G 100m", Category = "EL OCH INSTALLATION", SKU = "EL-FK-15GG", Price = 450m, Quantity = 18, MinStockLevel = 5 },
                new Product { Id = Guid.NewGuid(), Name = "Dimmer LED 3-100W", Category = "EL OCH INSTALLATION", SKU = "EL-DM-LED", Price = 495m, Quantity = 40, MinStockLevel = 10 },
                new Product { Id = Guid.NewGuid(), Name = "Apparatdosa Enkel", Category = "EL OCH INSTALLATION", SKU = "EL-AD-01", Price = 15m, Quantity = 300, MinStockLevel = 50 },
                new Product { Id = Guid.NewGuid(), Name = "Kopplingsdosa IP65", Category = "EL OCH INSTALLATION", SKU = "EL-KD-IP", Price = 45m, Quantity = 150, MinStockLevel = 40 },
                new Product { Id = Guid.NewGuid(), Name = "Säkring Automat C10 1-p", Category = "EL OCH INSTALLATION", SKU = "EL-SA-10", Price = 65m, Quantity = 60, MinStockLevel = 15 },
                new Product { Id = Guid.NewGuid(), Name = "Jordfelsbrytare 4-pol 25A", Category = "EL OCH INSTALLATION", SKU = "EL-JF-4P", Price = 695m, Quantity = 12, MinStockLevel = 4 },
                new Product { Id = Guid.NewGuid(), Name = "EKK-Kabel 3G1.5 Vit 25m", Category = "EL OCH INSTALLATION", SKU = "EL-EKK-25", Price = 385m, Quantity = 20, MinStockLevel = 5 },
                new Product { Id = Guid.NewGuid(), Name = "Grenuttag 5-vägs m. brytare", Category = "EL OCH INSTALLATION", SKU = "EL-GU-5V", Price = 129m, Quantity = 45, MinStockLevel = 10 },
                new Product { Id = Guid.NewGuid(), Name = "Rörelsedvakt 180 grader", Category = "EL OCH INSTALLATION", SKU = "EL-RV-180", Price = 345m, Quantity = 22, MinStockLevel = 6 },
                new Product { Id = Guid.NewGuid(), Name = "Kabelkanal 15x15mm 2m", Category = "EL OCH INSTALLATION", SKU = "EL-KK-15", Price = 49m, Quantity = 100, MinStockLevel = 20 },
                new Product { Id = Guid.NewGuid(), Name = "Digital Multimeter Pro", Category = "EL OCH INSTALLATION", SKU = "EL-DM-PRO", Price = 895m, Quantity = 8, MinStockLevel = 2 },
                new Product { Id = Guid.NewGuid(), Name = "LED-Panel 60x60 3000K", Category = "EL OCH INSTALLATION", SKU = "EL-LP-60", Price = 750m, Quantity = 15, MinStockLevel = 4 },
                new Product { Id = Guid.NewGuid(), Name = "Flexrör 16mm m. dragtråd", Category = "EL OCH INSTALLATION", SKU = "EL-FR-16", Price = 295m, Quantity = 30, MinStockLevel = 10 },
                new Product { Id = Guid.NewGuid(), Name = "Testmejsel 230V", Category = "EL OCH INSTALLATION", SKU = "EL-TM-230", Price = 39m, Quantity = 90, MinStockLevel = 20 },
                new Product { Id = Guid.NewGuid(), Name = "Vägglampa utomhus IP44", Category = "EL OCH INSTALLATION", SKU = "EL-VL-44", Price = 589m, Quantity = 25, MinStockLevel = 8 },
                new Product { Id = Guid.NewGuid(), Name = "Skarvsladd Gummi 10m", Category = "EL OCH INSTALLATION", SKU = "EL-SL-10G", Price = 299m, Quantity = 40, MinStockLevel = 10 },

                // TRÄDGÅRD OCH MASKINER (20 st)
                new Product { Id = Guid.NewGuid(), Name = "Gräsklippare Batteri 36V", Category = "TRÄDGÅRD OCH MASKINER", SKU = "TM-GK-36", Price = 4250m, Quantity = 10, MinStockLevel = 2 },
                new Product { Id = Guid.NewGuid(), Name = "Robotgräsklippare 1000m2", Category = "TRÄDGÅRD OCH MASKINER", SKU = "TM-RG-100", Price = 12900m, Quantity = 4, MinStockLevel = 1 },
                new Product { Id = Guid.NewGuid(), Name = "Häcksax 18V 55cm", Category = "TRÄDGÅRD OCH MASKINER", SKU = "TM-HS-18", Price = 1650m, Quantity = 15, MinStockLevel = 4 },
                new Product { Id = Guid.NewGuid(), Name = "Lövblås Ryggburen Bensin", Category = "TRÄDGÅRD OCH MASKINER", SKU = "TM-LB-BE", Price = 3895m, Quantity = 6, MinStockLevel = 2 },
                new Product { Id = Guid.NewGuid(), Name = "Trimmer Tråd 18V", Category = "TRÄDGÅRD OCH MASKINER", SKU = "TM-TR-18", Price = 995m, Quantity = 25, MinStockLevel = 6 },
                new Product { Id = Guid.NewGuid(), Name = "Motorsåg Batteridriven 30cm", Category = "TRÄDGÅRD OCH MASKINER", SKU = "TM-MS-30", Price = 2900m, Quantity = 7, MinStockLevel = 2 },
                new Product { Id = Guid.NewGuid(), Name = "Högtryckstvätt 140 bar", Category = "TRÄDGÅRD OCH MASKINER", SKU = "TM-HT-140", Price = 2495m, Quantity = 12, MinStockLevel = 3 },
                new Product { Id = Guid.NewGuid(), Name = "Grensax Teleskop 4 meter", Category = "TRÄDGÅRD OCH MASKINER", SKU = "TM-GS-T4", Price = 649m, Quantity = 20, MinStockLevel = 5 },
                new Product { Id = Guid.NewGuid(), Name = "Planteringsspade Stål", Category = "TRÄDGÅRD OCH MASKINER", SKU = "TM-PS-ST", Price = 129m, Quantity = 55, MinStockLevel = 10 },
                new Product { Id = Guid.NewGuid(), Name = "Sekatör Pro Sidoskär", Category = "TRÄDGÅRD OCH MASKINER", SKU = "TM-SE-PR", Price = 295m, Quantity = 45, MinStockLevel = 12 },
                new Product { Id = Guid.NewGuid(), Name = "Skottkärra 90L Svart", Category = "TRÄDGÅRD OCH MASKINER", SKU = "TM-SK-90", Price = 895m, Quantity = 18, MinStockLevel = 4 },
                new Product { Id = Guid.NewGuid(), Name = "Trädgårdsslang 25m vinda", Category = "TRÄDGÅRD OCH MASKINER", SKU = "TM-TS-25", Price = 699m, Quantity = 30, MinStockLevel = 8 },
                new Product { Id = Guid.NewGuid(), Name = "Kompostbehållare 300L", Category = "TRÄDGÅRD OCH MASKINER", SKU = "TM-KB-300", Price = 550m, Quantity = 14, MinStockLevel = 4 },
                new Product { Id = Guid.NewGuid(), Name = "Snöslunga Tvåstegs Bensin", Category = "TRÄDGÅRD OCH MASKINER", SKU = "TM-SS-BE", Price = 8500m, Quantity = 5, MinStockLevel = 2 },
                new Product { Id = Guid.NewGuid(), Name = "Vertikalskärare El", Category = "TRÄDGÅRD OCH MASKINER", SKU = "TM-VS-EL", Price = 1850m, Quantity = 8, MinStockLevel = 2 },
                new Product { Id = Guid.NewGuid(), Name = "Gödselvagn Universal", Category = "TRÄDGÅRD OCH MASKINER", SKU = "TM-GV-01", Price = 495m, Quantity = 22, MinStockLevel = 5 },
                new Product { Id = Guid.NewGuid(), Name = "Lövkrabba Plast 50cm", Category = "TRÄDGÅRD OCH MASKINER", SKU = "TM-LK-50", Price = 149m, Quantity = 60, MinStockLevel = 15 },
                new Product { Id = Guid.NewGuid(), Name = "Trädgårdshandskar Läder", Category = "TRÄDGÅRD OCH MASKINER", SKU = "TM-TH-LA", Price = 189m, Quantity = 80, MinStockLevel = 20 },
                new Product { Id = Guid.NewGuid(), Name = "Jordborr Bensin 52cc", Category = "TRÄDGÅRD OCH MASKINER", SKU = "TM-JB-52", Price = 3100m, Quantity = 3, MinStockLevel = 1 },
                new Product { Id = Guid.NewGuid(), Name = "Regnvattentunna 200L", Category = "TRÄDGÅRD OCH MASKINER", SKU = "TM-RT-200", Price = 429m, Quantity = 12, MinStockLevel = 3 },

                // FÄRG & MÅLERI (20 st)
                new Product { Id = Guid.NewGuid(), Name = "Väggfärg Matt Vit 10L", Category = "FÄRG & MÅLERI", SKU = "FM-VF-W10", Price = 895m, Quantity = 35, MinStockLevel = 10 },
                new Product { Id = Guid.NewGuid(), Name = "Takfärg Helmatt Vit 10L", Category = "FÄRG & MÅLERI", SKU = "FM-TF-W10", Price = 750m, Quantity = 25, MinStockLevel = 8 },
                new Product { Id = Guid.NewGuid(), Name = "Snickerifärg Halvblank 1L", Category = "FÄRG & MÅLERI", SKU = "FM-SF-HB", Price = 249m, Quantity = 40, MinStockLevel = 12 },
                new Product { Id = Guid.NewGuid(), Name = "Grundfärg Trä Inomhus 3L", Category = "FÄRG & MÅLERI", SKU = "FM-GF-TR", Price = 489m, Quantity = 20, MinStockLevel = 6 },
                new Product { Id = Guid.NewGuid(), Name = "Målarroller Maxi 25cm", Category = "FÄRG & MÅLERI", SKU = "FM-MR-25", Price = 129m, Quantity = 100, MinStockLevel = 30 },
                new Product { Id = Guid.NewGuid(), Name = "Penselset Pro 3-pack", Category = "FÄRG & MÅLERI", SKU = "FM-PS-03", Price = 195m, Quantity = 75, MinStockLevel = 20 },
                new Product { Id = Guid.NewGuid(), Name = "Maskeringstejp Precision 38mm", Category = "FÄRG & MÅLERI", SKU = "FM-MT-38", Price = 69m, Quantity = 150, MinStockLevel = 40 },
                new Product { Id = Guid.NewGuid(), Name = "Spackel Medium Allround 10L", Category = "FÄRG & MÅLERI", SKU = "FM-SM-10", Price = 289m, Quantity = 45, MinStockLevel = 15 },
                new Product { Id = Guid.NewGuid(), Name = "Täckpapp Pro 1x30m", Category = "FÄRG & MÅLERI", SKU = "FM-TP-30", Price = 185m, Quantity = 60, MinStockLevel = 15 },
                new Product { Id = Guid.NewGuid(), Name = "Sandpapper P120 5m rulle", Category = "FÄRG & MÅLERI", SKU = "FM-SP-120", Price = 89m, Quantity = 90, MinStockLevel = 25 },
                new Product { Id = Guid.NewGuid(), Name = "Metallyta Lackfärg Svart", Category = "FÄRG & MÅLERI", SKU = "FM-LF-BS", Price = 199m, Quantity = 30, MinStockLevel = 10 },
                new Product { Id = Guid.NewGuid(), Name = "Lasyr Utomhus Brun 3L", Category = "FÄRG & MÅLERI", SKU = "FM-LU-B3", Price = 645m, Quantity = 15, MinStockLevel = 5 },
                new Product { Id = Guid.NewGuid(), Name = "Penseltvätt Miljö 1L", Category = "FÄRG & MÅLERI", SKU = "FM-PT-1L", Price = 119m, Quantity = 35, MinStockLevel = 8 },
                new Product { Id = Guid.NewGuid(), Name = "Färgspruta Elektrisk 600W", Category = "FÄRG & MÅLERI", SKU = "FM-FS-600", Price = 1250m, Quantity = 8, MinStockLevel = 2 },
                new Product { Id = Guid.NewGuid(), Name = "Våtrumsfärg Vit 3L", Category = "FÄRG & MÅLERI", SKU = "FM-VF-V3", Price = 595m, Quantity = 18, MinStockLevel = 6 },
                new Product { Id = Guid.NewGuid(), Name = "Slippapper Kloss Ergonomisk", Category = "FÄRG & MÅLERI", SKU = "FM-SK-01", Price = 65m, Quantity = 55, MinStockLevel = 15 },
                new Product { Id = Guid.NewGuid(), Name = "Teleskopskaft Roller 2m", Category = "FÄRG & MÅLERI", SKU = "FM-TS-02", Price = 229m, Quantity = 30, MinStockLevel = 10 },
                new Product { Id = Guid.NewGuid(), Name = "Väggfärg Grå Harmoni 2.5L", Category = "FÄRG & MÅLERI", SKU = "FM-VF-G2", Price = 389m, Quantity = 25, MinStockLevel = 8 },
                new Product { Id = Guid.NewGuid(), Name = "Spackelspade Rostfri 150mm", Category = "FÄRG & MÅLERI", SKU = "FM-SS-15", Price = 145m, Quantity = 40, MinStockLevel = 12 },
                new Product { Id = Guid.NewGuid(), Name = "Målartvätt Spray 1L", Category = "FÄRG & MÅLERI", SKU = "FM-MT-1S", Price = 85m, Quantity = 65, MinStockLevel = 20 },

                // VVS & BADRUM (20 st)
                new Product { Id = Guid.NewGuid(), Name = "Tvättställsblandare Krom", Category = "VVS & BADRUM", SKU = "VV-TB-KR", Price = 1195m, Quantity = 15, MinStockLevel = 4 },
                new Product { Id = Guid.NewGuid(), Name = "Duschset m. Takdusch", Category = "VVS & BADRUM", SKU = "VV-DS-TD", Price = 3450m, Quantity = 8, MinStockLevel = 2 },
                new Product { Id = Guid.NewGuid(), Name = "Toalettstol Golvmodell", Category = "VVS & BADRUM", SKU = "VV-TS-GM", Price = 2895m, Quantity = 6, MinStockLevel = 2 },
                new Product { Id = Guid.NewGuid(), Name = "PEX-rör 15mm 25m", Category = "VVS & BADRUM", SKU = "VV-PX-15", Price = 750m, Quantity = 12, MinStockLevel = 4 },
                new Product { Id = Guid.NewGuid(), Name = "Vattenlås Universal Vit", Category = "VVS & BADRUM", SKU = "VV-VL-UN", Price = 149m, Quantity = 50, MinStockLevel = 15 },
                new Product { Id = Guid.NewGuid(), Name = "Klämringskoppling 15mm Rak", Category = "VVS & BADRUM", SKU = "VV-KK-15", Price = 65m, Quantity = 120, MinStockLevel = 30 },
                new Product { Id = Guid.NewGuid(), Name = "Silikon Våtrum Transparent", Category = "VVS & BADRUM", SKU = "VV-SI-VT", Price = 129m, Quantity = 85, MinStockLevel = 25 },
                new Product { Id = Guid.NewGuid(), Name = "Kulventil G15 med vred", Category = "VVS & BADRUM", SKU = "VV-KV-15", Price = 189m, Quantity = 40, MinStockLevel = 10 },
                new Product { Id = Guid.NewGuid(), Name = "Golvbrunn 150mm Sjöbo", Category = "VVS & BADRUM", SKU = "VV-GB-15", Price = 495m, Quantity = 10, MinStockLevel = 3 },
                new Product { Id = Guid.NewGuid(), Name = "Radiatorventil Termostat", Category = "VVS & BADRUM", SKU = "VV-RV-TE", Price = 325m, Quantity = 35, MinStockLevel = 10 },
                new Product { Id = Guid.NewGuid(), Name = "Varmvattenberedare 55L", Category = "VVS & BADRUM", SKU = "VV-VB-55", Price = 4800m, Quantity = 4, MinStockLevel = 1 },
                new Product { Id = Guid.NewGuid(), Name = "Bottenventil Pop-up Krom", Category = "VVS & BADRUM", SKU = "VV-BV-PU", Price = 249m, Quantity = 45, MinStockLevel = 12 },
                new Product { Id = Guid.NewGuid(), Name = "Cirkulationspump Klass A", Category = "VVS & BADRUM", SKU = "VV-CP-KA", Price = 2150m, Quantity = 7, MinStockLevel = 2 },
                new Product { Id = Guid.NewGuid(), Name = "Duschslang 1.5m Rostfri", Category = "VVS & BADRUM", SKU = "VV-DS-15", Price = 189m, Quantity = 60, MinStockLevel = 15 },
                new Product { Id = Guid.NewGuid(), Name = "Rörskärare Pro 3-35mm", Category = "VVS & BADRUM", SKU = "VV-RS-35", Price = 450m, Quantity = 14, MinStockLevel = 4 },
                new Product { Id = Guid.NewGuid(), Name = "Vattenmätarkonsol G20", Category = "VVS & BADRUM", SKU = "VV-VM-20", Price = 385m, Quantity = 5, MinStockLevel = 2 },
                new Product { Id = Guid.NewGuid(), Name = "Expansionskärl 18L", Category = "VVS & BADRUM", SKU = "VV-EK-18", Price = 995m, Quantity = 9, MinStockLevel = 2 },
                new Product { Id = Guid.NewGuid(), Name = "Handdukstork Elektrisk", Category = "VVS & BADRUM", SKU = "VV-HT-EL", Price = 1590m, Quantity = 11, MinStockLevel = 3 },
                new Product { Id = Guid.NewGuid(), Name = "Gängtejp 12mm x 12m", Category = "VVS & BADRUM", SKU = "VV-GT-12", Price = 25m, Quantity = 200, MinStockLevel = 50 },
                new Product { Id = Guid.NewGuid(), Name = "Backventil G20 Mässing", Category = "VVS & BADRUM", SKU = "VV-BV-20", Price = 275m, Quantity = 20, MinStockLevel = 6 }
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}
