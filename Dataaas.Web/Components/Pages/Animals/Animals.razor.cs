using Dataaas.Web.Models;
using Microsoft.AspNetCore.Components;

namespace Dataaas.Web.Components.Pages.Animals;

public sealed partial class Animals
{
    [Inject]
    private NavigationManager Navigation { get; set; } = null!;

    private List<ApiSummary> AnimalApis { get; set; } = [];

    protected override void OnInitialized()
    {
        AnimalApis =
        [
            new ApiSummary("Cat Facts", "Daily cat facts! 🐱", "/animals/cat-facts"),
            new ApiSummary("CATAAS", "Cat as a service", "#"),
            new ApiSummary("Dog Facts", "Random dog facts", "#"),
            new ApiSummary("Dog API", "This is the Dog API and it provides dog facts as a service dogdog 🐶", "#"),
            new ApiSummary("Dog API", "The internet's biggest collection of open source dog pictures.", "#"),
            new ApiSummary("HTTP Cats", "Cat for every HTTP Status", "#"),
            new ApiSummary("HTTP Dogs", "Dogs for every HTTP response status code", "#"),
            new ApiSummary("MeowFacts", "A simple api that returns a random fact about cats on a GET request", "#"),
            new ApiSummary("PlaceBear", "Placeholder bear pictures", "#"),
            new ApiSummary("PlaceDog", "Placeholder Dog pictures", "#"),
            new ApiSummary("PlaceKitten", "Placeholder kitten pictures", "#")
        ];
    }

    private void NavigateToApi(ApiSummary api)
    {
        Navigation.NavigateTo(api.Route);
    }
}