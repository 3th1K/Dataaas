namespace Dataaas.Web.Models;

public class ApiSummary
{
    public string ApiId { get; }
    public string Name { get; }
    public string ShortDescription { get; }
    public string Route { get; }

    public ApiSummary(string name, string shortDescription, string route)
    {
        ApiId = Guid.NewGuid().ToString();
        Name = name;
        ShortDescription = shortDescription;
        Route = route;
    }
}