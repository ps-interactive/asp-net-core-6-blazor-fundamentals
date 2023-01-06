using BethanysPieShop.Client.Models;
using BethanysPieShop.Shared;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Client.Pages
{
    public partial class PieOverview
    {
        [Inject]
        public IPieDataService PieDataService { get; set; }

        public List<Pie> Pies{ get; set; }

        protected async override Task OnInitializedAsync()
        {
            Pies = (await PieDataService.GetAllPies()).ToList();
        }

    }
}
