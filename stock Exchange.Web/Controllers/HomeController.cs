using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StockExchange.Domain.Domain;
using StockExchange.Web.Models;
using StockExchange.Web.Services;
using StockExchange.Web.Services.Wallet;


namespace StockExchange.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRatesServices _ratesServices;
        private readonly IUserWalletService _userWalletService;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(UserManager<ApplicationUser> userManager, IRatesServices ratesServices, IUserWalletService userWalletService)
        {
            _userManager = userManager;
            _ratesServices = ratesServices;
            _userWalletService = userWalletService;
        }
        public async Task< IActionResult> Index()
        {
            var model = new HomeViewModel {StockRates = await _ratesServices.GetStockRates()};
            if (User.Identity.IsAuthenticated)
            {
                model.UserWallet = await _userWalletService.GetUserWallet(_userManager.GetUserId(User));
            }
            return View(model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
