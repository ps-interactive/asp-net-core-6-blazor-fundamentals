using BethanysPieShop.Shared;

namespace BethanysPieShop.Client.Models
{
    public interface IMockPieDataService
    {
        IEnumerable<Pie> AllPies { get; }
    }
}
