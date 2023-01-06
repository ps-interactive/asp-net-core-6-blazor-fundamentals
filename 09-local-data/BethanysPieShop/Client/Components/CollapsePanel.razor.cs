using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Client.Components
{
    public partial class CollapsePanel
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }



        public bool Collapsed { get; set; } = true;

        public void Toggle()
        { 
            Collapsed= !Collapsed;
        }

    }
}
