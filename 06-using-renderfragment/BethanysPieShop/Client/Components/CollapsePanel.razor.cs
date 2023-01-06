using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Client.Components
{
    public partial class CollapsePanel
    {


        public bool Collapsed { get; set; } = true;

        public void Toggle()
        { 
            Collapsed= !Collapsed;
        }

    }
}
