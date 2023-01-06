using BethanysPieShop.Client.Models;
using BethanysPieShop.Shared;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Client.Pages
{
    public partial class PieOverview
    {
        [Inject]
        public IMockPieDataService MockPieDataService { get; set; }

        public List<Pie> Pies{ get; set; }

        protected override void OnInitialized()
        {
            Pies = MockPieDataService.AllPies.ToList();
        }
    }
}
