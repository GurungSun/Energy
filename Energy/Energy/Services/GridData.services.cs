using Energy.Models;
using Energy.Data;

namespace Energy.Services;

public class EnergyService
{
    private readonly HttpClient _httpClient;

    public EnergyService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<GridData?> GetCurrentGridDataAsync()
    {
        // --- TEMPORARY MOCK DATA ---
    // Remove this block once we figure out your network firewall!
        return new GridData
        {
            From = DateTime.UtcNow.AddMinutes(-30),
            To = DateTime.UtcNow,
            GenerationMix = new List<FuelMix>
            {
                new FuelMix { Fuel = "wind", Perc = 42.5 },
                new FuelMix { Fuel = "gas", Perc = 28.1 },
                new FuelMix { Fuel = "nuclear", Perc = 14.3 },
                new FuelMix { Fuel = "solar", Perc = 8.0 },
                new FuelMix { Fuel = "coal", Perc = 2.1 }
            }
        };

        try
        {
            var result = await _httpClient.GetFromJsonAsync<GenerationResponse>("generation");
            return result?.Data;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching grid data: {ex.Message}");
            // Add this line to reveal the true culprit!
            Console.WriteLine($"Inner Exception: {ex.InnerException?.Message}");
            return null;
        }
    }
}