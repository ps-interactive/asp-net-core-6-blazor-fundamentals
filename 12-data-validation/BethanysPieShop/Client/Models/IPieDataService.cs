using BethanysPieShop.Shared;

namespace BethanysPieShop.Client.Models
{
    public interface IPieDataService
    {
        Task<IEnumerable<Pie>> GetAllPies();
        Task<Pie> GetPieById(int pieId);
    }
}