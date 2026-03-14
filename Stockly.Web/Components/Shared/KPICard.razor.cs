namespace Stockly.Web.Components.Shared;

public partial class KPICard
{
    [Parameter]
    public string Text { get; set; } = string.Empty;

    [Parameter]
    public string? SmallText { get; set; }

    [Parameter]
    public string Icon { get; set; } = string.Empty;

    [Parameter]
    public BootstrapColor Color { get; set; }

    [EditorRequired]
    [Parameter]
    public int KeyPerformanceValue { get; set; }
}
