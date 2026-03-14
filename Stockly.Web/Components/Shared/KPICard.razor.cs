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
    public DisplayFormat DisplayFormat { get; set; }

    [EditorRequired]
    [Parameter]
    public TValue KeyPerformanceValue { get; set; }

    private string? _backgroundColor { get; set; }
    private string? _textColor { get; set; }
    private string _formatString { get; set; } = string.Empty;

    protected override void OnParametersSet()
    {
        SetFormatString();
        SetColorClasses();
    }

    private void SetFormatString()
    {
        switch (DisplayFormat)
        {
            case DisplayFormat.Standard:
                _formatString = "{0}";
                break;
            case DisplayFormat.Currency:
                _formatString = "{0:C}";
                break;
            case DisplayFormat.Number:
                _formatString = "{0:N0}";
                break;
            case DisplayFormat.Percentage:
                _formatString = "{0:P1}";
                break;
            default:
                _formatString = "{0}";
                break;
        }
    }

    private void SetColorClasses()
    {
        switch (Color)
        {
            case BootstrapColor.Primary:
                _backgroundColor = "bg-primary";
                _textColor = "text-primary";
                break;
            case BootstrapColor.Success:
                _backgroundColor = "bg-success";
                _textColor = "text-success";
                break;
            case BootstrapColor.Warning:
                _backgroundColor = "bg-warning";
                _textColor = "text-warning";
                break;
            case BootstrapColor.Danger:
                _backgroundColor = "bg-danger";
                _textColor = "text-danger";
                break;
            default:
                _backgroundColor = "bg-secondary";
                _textColor = "text-secondary";
                break;
        }
    }
}
