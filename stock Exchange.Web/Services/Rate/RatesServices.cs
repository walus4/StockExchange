using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StockExchange.Web.Data;
using StockExchange.Web.Models;

namespace StockExchange.Web.Services
{
    public class RatesServices: IRatesServices
    {
    
        public async Task<StockRates> GetStockRates()
        {
            try
            {
                var content = string.Empty;
                using (WebClient reader = new WebClient())
                {
                    content = reader.DownloadString("http://webtask.future-processing.com:8068/stocks");
                }

                if (!string.IsNullOrEmpty(content))
                {
                    var stockRates= JsonConvert.DeserializeObject<StockRates>(content);
                    return stockRates;
                }

                return null;
            }
            catch (System.Exception)
            {

                return null;
            }
        }
    }
}