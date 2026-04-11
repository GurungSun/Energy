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