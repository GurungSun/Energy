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
            var response = await _httpClient.GetFromJsonAsync<GridData>("https://api.grid-data.co.uk/v1/current");
            return response;
        }
        catch (Exception ex)
        {
            // Handle error, e.g., log or return null
            Console.WriteLine($"Error fetching grid data: {ex.Message}");
            return null;
        }
    }
}