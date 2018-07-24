using System;
using System.Threading.Tasks;
using StockExchange.Web.Models;

namespace StockExchange.Web.Services.Wallet
{
    public interface IUserWalletService
    {
       Task< UserWalletViewModel> GetUserWallet(string userId);
    }
}