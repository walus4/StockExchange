using StockExchange.Domain;

namespace StockExchange.Web.Models
{
    public class Stock : Company
    {
        public decimal Price { get; set; }
    }
}