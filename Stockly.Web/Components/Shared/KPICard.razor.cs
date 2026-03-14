namespace Stockly.Web.Components.Shared;

public partial class KPICard<TValue> where TValue : INumber<TValue>
{
    [Parameter]
    public string Text { get; set; } = string.Empty;

    [Parameter]
    public string? SmallText { get; set; }

    [Parameter]
    public string Icon { get; set; } = string.Empty;

    [Parameter]
    public BootstrapColor Color { get; set; }

    [Parameter]
    public string FormatString { get; set; } = string.Empty;

    [EditorRequired]
    [Parameter]
    public TValue KeyPerformanceValue { get; set; }

    public string? BackgroundColor { get; set; }
    public string? TextColor { get; set; }

    protected override void OnInitialized()
    {
        SetColorClasses();
    }

    private void SetColorClasses()
    {
        switch (Color)
        {
            case BootstrapColor.Primary:
                BackgroundColor = "bg-primary";
                TextColor = "text-primary";
                break;
            case BootstrapColor.Success:
                BackgroundColor = "bg-success";
                TextColor = "text-success";
                break;
            case BootstrapColor.Warning:
                BackgroundColor = "bg-warning";
                TextColor = "text-warning";
                break;
            case BootstrapColor.Danger:
                BackgroundColor = "bg-danger";
                TextColor = "text-danger";
                break;
            default:
                BackgroundColor = "bg-secondary";
                TextColor = "text-secondary";
                break;
        }
    }
}
