using System.Collections.Generic;
using System.Threading.Tasks;
using ChartJSCore.Models;

namespace StockExchange.Web.Services.Chart
{
    public interface IChartService
    {
        Task<ChartJSCore.Models.Chart> GetGraphData();
    }
}