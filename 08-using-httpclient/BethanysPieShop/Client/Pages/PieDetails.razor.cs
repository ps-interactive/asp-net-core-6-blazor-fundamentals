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
        public IPieDataService PieDataService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Pie = await PieDataService.GetPieById(int.Parse(PieId));
        }
    }
}
