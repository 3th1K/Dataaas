using System.Text.Json.Serialization;
using Dataaas.Web.Models.Animals.CatFacts;

namespace Dataaas.Web.Services.Animals.CatFacts;

public class CatFactsService : ICatFactsService
{
    private readonly HttpClient _httpClient;

    public CatFactsService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<FactModel>> GetRandomFactsAsync(int count)
    {
        List<FactModel> filteredFacts = [];
        while (filteredFacts.Count < count)
        {
            var response = await _httpClient.GetFromJsonAsync<List<FactModel>>($"facts/random?animal_type=cat&amount={count * 2}");
            if (response is null || response.Count == 0)
            {
                continue;
            }
            var filtered = response.Where(r => r.Status.Verified is true);
            if (!filtered.Any())
            {
                continue;
            }
            filteredFacts.AddRange(filtered);
        }

        return filteredFacts.Take(count).ToList();
    }
}