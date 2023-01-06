using BethanysPieShop.Shared;

namespace BethanysPieShop.Client.Pages
{
    public partial class PieOverview
    {
        public Pie RandomPie { get; set; }

        protected override void OnInitialized()
        {
            RandomPie = new Pie { PieId = 1, Name = "Strawberry Pie", Price = 15.95M, ShortDescription = "Lorem Ipsum", LongDescription = "Icing carrot", InStock = true, IsPieOfTheWeek = false };
            base.OnInitialized();
        }
    }
}
