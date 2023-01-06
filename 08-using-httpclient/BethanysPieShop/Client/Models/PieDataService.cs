using BethanysPieShop.Shared;
using System.Text.Json;

namespace BethanysPieShop.Client.Models
{
    public class PieDataService: IPieDataService
    {
        private readonly HttpClient _httpClient = default!;

        public PieDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Pie>> GetAllPies()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Pie>>
                (await _httpClient.GetStreamAsync($"api/pie"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Pie> GetPieById(int pieId)
        {
            return await JsonSerializer.DeserializeAsync<Pie>
                (await _httpClient.GetStreamAsync($"api/pie{pieId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
