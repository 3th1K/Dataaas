using System.Text.Json.Serialization;

namespace Dataaas.Web.Models.Animals.CatFacts;

public class FactModel
{
    [JsonPropertyName("status")]
    public Status Status { get; set; }

    [JsonPropertyName("_id")]
    public string Id { get; set; }

    [JsonPropertyName("user")]
    public string User { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("deleted")]
    public bool Deleted { get; set; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("__v")]
    public int Version { get; set; }
}

public class Status
{
    [JsonPropertyName("verified")]
    public bool? Verified { get; set; }  // Nullable because verified is null in the data

    [JsonPropertyName("sentCount")]
    public int SentCount { get; set; }
}