using Dataaas.Web.Models.Animals.CatFacts;
using Dataaas.Web.Services.Animals.CatFacts;
using Microsoft.AspNetCore.Components;

namespace Dataaas.Web.Components.Pages.Animals.CatFacts;

public sealed partial class CatFacts
{
    [Inject]
    private ICatFactsService catFactsService { get; set; } = null!;

    public List<FactModel> Facts { get; private set; } = [];

    public async Task GetAsync()
    {
        var newFacts = await catFactsService.GetRandomFactsAsync(5);
        Facts = newFacts;
    }
}