using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockExchange.Domain;
using StockExchange.Web.Data;
using StockExchange.Web.Models;

namespace StockExchange.Web.Services.Wallet
{
    public class UserWalletService: IUserWalletService
    {
        private readonly ApplicationDbContext _context;

        public UserWalletService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task< UserWalletViewModel> GetUserWallet(string userId)
        {
            if (userId!=null)
            {
                var userWallet = new UserWalletViewModel
                {
                    Money = _context.UserCurrecnies.FirstOrDefault(w=>w.UserId==userId)?.Amount??0,
                    UserStocksWallet = new List<UserStocksWallet>(from stock in _context.UserActionses
                                                                  join company in _context.Companies on stock.ActionCode equals company.Code
                                                                  where stock.UserId == userId
                                                                  select new UserStocksWallet
                                                                  {
                                                                      Name = company.Name,
                                                                      Value = stock.Amount,
                                                                      Amount = company.Unit,
                                                                      Code = company.Code,
                                                                      Unit = company.Unit,
                                                                      ActualPrice = _context.ShereRateses.OrderByDescending(w => w.DateTimeRates).FirstOrDefault(w => w.Code == company.Code).Rate
                                                                  })};
                return  userWallet;
            }
            return new UserWalletViewModel{Money = 0,UserStocksWallet = new List<UserStocksWallet>()};
        }
    }
}