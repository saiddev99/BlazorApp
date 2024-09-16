using Microsoft.AspNetCore.Components;

namespace Blazor.Client.Pages;

public partial class Dobbelen
{
    [Parameter]
    public int Aantal { get; set; }

    private List<int> results = new();

    private void Gooi()
    {
        results.Clear();

        Random random = new Random();

        for (int i = 0; i < Aantal; i++)
        {
            results.Add(random.Next(1, 7));
        }
    }

    public override async Task SetParametersAsync(ParameterView parameters)
    {
        await base.SetParametersAsync(parameters);
        if (Aantal == 0) Aantal = 2;
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();
    }

}
