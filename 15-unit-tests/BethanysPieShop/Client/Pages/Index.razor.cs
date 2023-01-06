using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BethanysPieShop.Client.Pages
{
    public partial class Index
    {
        [Inject]
        public NavigationManager NavigationManager{ get; set; }

        [Inject]
        public IJSRuntime JSRuntime{ get; set; }

        public async Task NavigateAway()
        {
            if (!await  JSRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to navigate to Pluralsight.com?"))
                return;

            NavigationManager.NavigateTo("https://www.pluralsight.com");
        }


    }
}
