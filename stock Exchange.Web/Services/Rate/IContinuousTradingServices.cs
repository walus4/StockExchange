using System.Threading.Tasks;

namespace StockExchange.Web.Services.Rate
{
    public interface IContinuousTradingServices
    {
        Task ContinuousTrading();
    }
}