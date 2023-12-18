using System.Text.Json.Serialization;

public class Breed
{
    public Dimension? Weight { get; set; }
    public Dimension? Height { get; set; }
    public int Id { get; set; }
    public string? Name { get; set; }
    [JsonPropertyName("country_code")]
    public string? CountryCode { get; set; }
    [JsonPropertyName("bred_for")]
    public string? BredFor { get; set; }
    [JsonPropertyName("breed_group")]
    public string? BreedGroup { get; set; }
    [JsonPropertyName("life_span")]
    public string? LifeSpan { get; set; }
    public string? Temperament { get; set; }
    public string? Origin { get; set; }
    [JsonPropertyName("reference_image_id")]
    public string? ReferenceImageId { get; set; }
}

public class Dimension
{
    public string? Imperial { get; set; }
    public string? Metric { get; set; }
}