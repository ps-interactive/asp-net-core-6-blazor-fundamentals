using BethanysPieShop.Shared;
using Blazored.LocalStorage;
using System.Collections.Generic;
using System.Text.Json;

namespace BethanysPieShop.Client.Models
{
    public class PieDataService : IPieDataService
    {
        private readonly HttpClient _httpClient = default!;
        private readonly ILocalStorageService _localStorageService;

        public PieDataService(HttpClient httpClient, ILocalStorageService localStorageService)
        {
            _httpClient = httpClient;
            _localStorageService = localStorageService;
        }

        public async Task<IEnumerable<Pie>> GetAllPies()
        {
            if (await _localStorageService.ContainKeyAsync("pies"))
            {
                return await _localStorageService.GetItemAsync<List<Pie>>("pies");
            }
            else
            {

                var list = await JsonSerializer.DeserializeAsync<IEnumerable<Pie>>
                    (await _httpClient.GetStreamAsync($"api/pie"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

                await _localStorageService.SetItemAsync("pies", list);
                return list;
            }
        }

        public async Task<Pie> GetPieById(int pieId)
        {
            return await JsonSerializer.DeserializeAsync<Pie>
                (await _httpClient.GetStreamAsync($"api/pie/{pieId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
