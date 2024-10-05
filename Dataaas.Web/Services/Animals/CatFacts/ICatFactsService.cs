using Dataaas.Web.Models.Animals.CatFacts;

namespace Dataaas.Web.Services.Animals.CatFacts;

public interface ICatFactsService
{
    Task<List<FactModel>> GetRandomFactsAsync(int count);
}