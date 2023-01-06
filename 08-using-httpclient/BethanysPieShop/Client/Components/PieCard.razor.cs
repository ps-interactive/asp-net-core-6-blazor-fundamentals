using BethanysPieShop.Shared;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Client.Components
{
    public partial class PieCard
    {
        [Parameter]
        public Pie Pie { get; set; }

        protected override void OnInitialized()
        {
            if (string.IsNullOrEmpty(Pie.Name))
            {
                throw new Exception();
            }
        }
    }
}
