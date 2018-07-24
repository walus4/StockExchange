using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChartJSCore.Models;
using StockExchange.Web.Data;

namespace StockExchange.Web.Services.Chart
{
    public class ChartService: IChartService
    {
        private readonly ApplicationDbContext _context;

        public ChartService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task< ChartJSCore.Models.Chart> GetGraphData()
        {
            Random random = new Random();
            ChartJSCore.Models.Chart chart = new ChartJSCore.Models.Chart();

            chart.Type = "line";
            ChartJSCore.Models.Data data = new ChartJSCore.Models.Data();
            data.Labels = (from contextShereRatese in _context.ShereRateses
                select contextShereRatese.DateTimeRates.ToLongTimeString()).Distinct().ToList();
            data.Datasets = new List<Dataset>();
            foreach (var companyCode in _context.Companies.Select(w => w.Code))
            {
                string coloRround = "rbga(" + random.Next(0, 255)+","+ random.Next(0, 255)+","+ random.Next(0, 255);

                List<decimal> list = new List<decimal>();
                foreach (decimal @decimal in (_context.ShereRateses.Where(w=>w.Code==companyCode).Select(
                    contextShereRatese => contextShereRatese.Rate))) list.Add(@decimal);
                LineDataset dataset = new LineDataset()
                {
                    Label = companyCode,
                    Data = list as IList<double>,
                    Fill = "false",
                    LineTension = 0.1,
                    BackgroundColor = coloRround+",0.4)",
                    BorderColor = coloRround+",1)",
                    BorderCapStyle = "butt",
                    BorderDash = new List<int> { },
                    BorderDashOffset = 0.0,
                    BorderJoinStyle = "miter",
                    PointBorderColor = new List<string>() { coloRround + ",1)"},
                    PointBackgroundColor = new List<string>() {"#fff"},
                    PointBorderWidth = new List<int> {1},
                    PointHoverRadius = new List<int> {5},
                    PointHoverBackgroundColor = new List<string>() { coloRround + ",1)"},
                    PointHoverBorderColor = new List<string>() {"rgba(220,220,220,1)"},
                    PointHoverBorderWidth = new List<int> {2},
                    PointRadius = new List<int> {1},
                    PointHitRadius = new List<int> {10},
                    SpanGaps = false
                };
                data.Datasets.Add(dataset);
            }
            chart.Data = data;
            return chart;
        }
    }
}