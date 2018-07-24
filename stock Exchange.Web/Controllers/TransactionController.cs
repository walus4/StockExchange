using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;
using StockExchange.Domain.Domain;
using StockExchange.Web.Services.Transaction;

namespace StockExchange.Web.Controllers
{
    public class TransactionController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ITransactionServices _transactionServices;

        public TransactionController(UserManager<ApplicationUser> userManager,ITransactionServices transactionServices)
        {
            _userManager = userManager;
            _transactionServices = transactionServices;
        }

        
        public IActionResult BuyAction(string actionCode, int actionUnit, decimal actionPrice)
        {
            if (User.Identity.IsAuthenticated)
            {

                var userID = _userManager.GetUserId(User);
                     _transactionServices.BuyAction( actionCode,  actionUnit,  actionPrice,userID);
            }
            return RedirectToAction("Index", "Home");
        }

        
        public IActionResult SellAction(string actionCode, int actionUnit, decimal actionPrice)
        {
            if (User.Identity.IsAuthenticated)
            {

                var userID = _userManager.GetUserId(User);
                     _transactionServices.SellAction( actionCode,  actionUnit,  actionPrice,userID);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}