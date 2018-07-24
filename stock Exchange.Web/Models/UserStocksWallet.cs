namespace StockExchange.Web.Models
{
    public class UserStocksWallet : Stock
    {
        public int Amount { get; set; }

        public int Value { get; set; }

        public decimal ActualPrice { get; set; }
    }
}