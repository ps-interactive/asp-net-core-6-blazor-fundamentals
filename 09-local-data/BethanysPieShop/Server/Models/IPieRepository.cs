using BethanysPieShop.Shared;

namespace BethanysPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        Pie? GetPieById(int pieId);

    }
}
