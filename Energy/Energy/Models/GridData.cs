namespace Energy.Models;
using System.Text.Json.Serialization;


public class GenerationResponse
{
    [JsonPropertyName("data")]
    public GridData Data { get; set; }
}

public class GridData
{
    [JsonPropertyName("from")]
    public DateTime From { get; set; }

    [JsonPropertyName("to")]
    public DateTime To { get; set; }

    [JsonPropertyName("generationmix")]
    public List<FuelMix> GenerationMix { get; set; } = new();
}

public class FuelMix
{
    [JsonPropertyName("fuel")]
    public string Fuel { get; set; } = string.Empty;

    [JsonPropertyName("perc")]
    public double Perc { get; set; }
}