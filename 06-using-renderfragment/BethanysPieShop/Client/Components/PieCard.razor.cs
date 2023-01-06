using BethanysPieShop.Shared;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Client.Components
{
    public partial class PieCard
    {
        [Parameter]
        public Pie Pie { get; set; }
    }
}
