using System.Threading.Tasks;
using StockExchange.Web.Models;

namespace StockExchange.Web.Services
{
    public interface IRatesServices
    {
        Task<StockRates> GetStockRates();


    }
}