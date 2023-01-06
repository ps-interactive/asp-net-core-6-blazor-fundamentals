using BethanysPieShop.Client.Models;
using BethanysPieShop.Shared;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Client.Pages
{
    public partial class PieEdit
    {
        [Parameter]
        public string PieId { get; set; }

        public Pie Pie { get; set; } = new Pie();

        [Inject]
        public IPieDataService PieDataService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            if (!string.IsNullOrEmpty(PieId))
            {
                Pie = await PieDataService.GetPieById(int.Parse(PieId));
            }
        }

        public void Button_Click()
        {
            Pie.Name= "Cheese cake";

        }
    }
}
