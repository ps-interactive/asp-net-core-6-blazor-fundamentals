namespace BethanysPieShop.Components
{
    public partial class StockAlert
    {

        public string StockMessage { get; set; }

        protected override void OnInitialized()
        {
            int rnd = new Random().Next(10);
            if (rnd <= 5)
                StockMessage = "Stock is running low";
            else
                StockMessage = "Stock OK";
        }
    }
}
