using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StockExchange.Domain.Domain;
using StockExchange.Web.Data;

namespace StockExchange.Web.Services.Transaction
{
    public class TransactionServices: ITransactionServices
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public TransactionServices(ApplicationDbContext context,UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public  async  Task BuyAction(string actionCode, int actionUnit, decimal actionPrice, string userId)
        {
            try
            {

                var action =  _context.StockActionses.FirstOrDefault(w => w.ActionCode == actionCode);
                var company =  _context.Companies.FirstOrDefault(w => w.Code == actionCode);
                if (action == null)
                {

                }
                action.Amount = action.Amount - company.Unit * 1;
                _context.StockActionses.Update(action);
                 _context.SaveChanges();
                if (_context.UserActionses.Any(w => w.UserId == userId && w.ActionCode == actionCode))
                {
                    var userAction =  _context.UserActionses.FirstOrDefault(w => w.UserId == userId && w.ActionCode == actionCode);
                    userAction.Amount += company.Unit * 1;
                    _context.UserActionses.Update(userAction);
                     _context.SaveChanges();
                }
                else
                {
                     _context.UserActionses.Add(new UserActions { ActionCode = actionCode, Amount = company.Unit * 1, UserId = userId });
                     _context.SaveChanges();
                }

                var userMoney = _context.UserCurrecnies.FirstOrDefault(w => w.UserId == userId);
                userMoney.Amount = userMoney.Amount - ((company.Unit * 1) * actionPrice);
                _context.UserCurrecnies.Update(userMoney);
                 _context.SaveChanges();

            }
            catch (System.Exception e)
            {

                throw;
            }
        }

        public async Task SellAction(string actionCode, int actionUnit, decimal actionPrice, string userId)
        {
            var action =  _context.UserActionses.FirstOrDefault(w => w.ActionCode == actionCode);
            if (action == null)
            {

            }

            var company =  _context.Companies.FirstOrDefault(w => w.Code == actionCode);
            action.Amount = action.Amount - company.Unit * 1;
            if (action.Amount==0)
            {
                _context.Remove(action);

            }
            else
            {

                _context.UserActionses.Update(action); 
            }
            _context.SaveChanges();
            if (_context.StockActionses.Any(w => w.ActionCode == actionCode))
            {
                var stockAction = _context.StockActionses.FirstOrDefault(w => w.ActionCode == actionCode);
                stockAction.Amount += company.Unit * 1;
                _context.StockActionses.Update(stockAction);
                _context.SaveChanges();
            }
            else
            {
                _context.StockActionses.Add(new StockActions {  ActionCode = actionCode, Amount = company.Unit * 1 });
            }
            var userMoney = _context.UserCurrecnies.FirstOrDefault(w => w.UserId == userId);
            userMoney.Amount = userMoney.Amount + ((company.Unit * 1) * actionPrice);
            _context.UserCurrecnies.Update(userMoney);
            _context.SaveChanges();
        }
    }
}