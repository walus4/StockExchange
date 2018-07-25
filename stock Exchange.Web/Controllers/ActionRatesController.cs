using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockExchange.Web.Services;

namespace StockExchange.Web.Controllers
{
    public class ActionRatesController : Controller
    {
        private readonly IRatesServices _ratesServices;

        public ActionRatesController(IRatesServices ratesServices)
        {
            _ratesServices = ratesServices;
        }
        public async Task<PartialViewResult> Index()
        {
            var rates = await _ratesServices.GetStockRates();
            return PartialView(rates);
        }
    }
}