using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StockExchange.Domain.Domain;
using StockExchange.Web.Services;
using StockExchange.Web.Services.Wallet;

namespace StockExchange.Web.Controllers
{
    

    
    public class UserWalletController : Controller
    {
        private readonly IUserWalletService _userWalletService;
        private readonly UserManager<ApplicationUser> _userManager;
        public UserWalletController(IUserWalletService userWalletService, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _userWalletService = userWalletService;

        }
        public async Task<PartialViewResult> GetUserWallet()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userWallet = await _userWalletService.GetUserWallet(_userManager.GetUserId(User));
                return PartialView(userWallet);
            }
            Response.StatusCode = 500;
            return PartialView("Exception");
        }
    }
}