using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChartJSCore.Models;
using StockExchange.Web.Services.Chart;

namespace StockExchange.Web.Controllers
{
    public class ChartController : Controller
    {
        private readonly IChartService _chartService;

        public ChartController(IChartService chartService)
        {
            _chartService = chartService;
        }
        // GET
        public async Task<IActionResult> Chart()
        {
            Chart chart = await _chartService.GetGraphData();

            ViewData["chart"] = chart;

            return View();
        }
    }
}