using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockExchange.Domain.Domain;
using StockExchange.Web.Data;

namespace StockExchange.Web.Services.Rate
{
    public class ContinuousTradingServices : IContinuousTradingServices
    {
        private readonly ApplicationDbContext _context;
        private readonly IRatesServices _ratesServices;

        public ContinuousTradingServices(ApplicationDbContext context, IRatesServices ratesServices)
        {
            _context = context;
            _ratesServices = ratesServices;
        }

        public async Task ContinuousTrading()
        {
            var actualCurses = await _ratesServices.GetStockRates();
            var last = _context.ShereRateses.LastOrDefault();
            if (actualCurses != null)
            {
                if (last?.DateTimeRates < actualCurses.PublicationDate || last == null)
                {
                    var newCoureses = (from rate in actualCurses.Items
                        select new ShareRates
                        {
                            Code = rate.Code,
                            DateTimeRates = actualCurses.PublicationDate,
                            Rate = rate.Price
                        }).ToList();
                     _context.ShereRateses.AddRange(newCoureses);
                     _context.SaveChanges();
                }
            }
        }
    }
}