using MudBlazor;
using MudBlazor.Utilities;

namespace L3.Web.Layout;

public sealed class L3FinancePallete : PaletteDark
{
    public L3FinancePallete()
    {
        Primary = new MudColor("#9966FF");
        Secondary = new MudColor("#F6AD31");
        Tertiary = new MudColor("#8AE491");
    }

    public static L3FinancePallete CreatePallete => new();
}
