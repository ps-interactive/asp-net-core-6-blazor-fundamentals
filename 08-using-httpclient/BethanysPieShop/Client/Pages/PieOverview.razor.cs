using BethanysPieShop.Client.Models;
using BethanysPieShop.Shared;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Client.Pages
{
    public partial class PieOverview
    {
        

        public List<Pie> Pies{ get; set; } = new List<Pie>();

        protected async override Task OnInitializedAsync()
        {
            
        }

    }
}
