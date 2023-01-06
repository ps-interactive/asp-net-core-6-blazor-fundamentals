using BethanysPieShop.Shared;
using System.Text.Json;

namespace BethanysPieShop.Client.Models
{
    public class PieDataService: IPieDataService
    {

        public async Task<IEnumerable<Pie>> GetAllPies()
        {
            return null;
        }

        public async Task<Pie> GetPieById(int pieId)
        {
            return null;

        }
    }
}
