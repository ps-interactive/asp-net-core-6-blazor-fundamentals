using BethanysPieShop.Shared;
using System.Net.Http;
using System.Text.Json;

namespace BethanysPieShop.Client.Models
{
    public class PieDataService: IPieDataService
    {

        public async Task<IEnumerable<Pie>> GetAllPies()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Pie>>
                (await _httpClient.GetStreamAsync($"api/pie"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Pie> GetPieById(int pieId)
        {
            return null;

        }
    }
}
