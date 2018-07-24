using System.Threading.Tasks;

namespace StockExchange.Web.Services.Transaction
{
    public interface ITransactionServices
    {
        Task BuyAction(string actionCode, int actionUnit, decimal actionPrice, string userId);
        Task SellAction(string actionCode, int actionUnit, decimal actionPrice, string userId);
    }
}