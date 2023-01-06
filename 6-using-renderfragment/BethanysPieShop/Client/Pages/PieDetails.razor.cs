using BethanysPieShop.Client.Models;
using BethanysPieShop.Shared;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Client.Pages
{
    public partial class PieDetails
    {
        [Parameter]
        public string PieId { get; set; }

        public Pie Pie { get; set; }

        [Inject]
        public IMockPieDataService MockPieDataService { get; set; }

        protected override void OnInitialized()
        {
            Pie = MockPieDataService.AllPies.Where(i => i.PieId == Int32.Parse(PieId)).FirstOrDefault();
        }
    }
}
