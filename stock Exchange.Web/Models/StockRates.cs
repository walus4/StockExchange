using System;
using System.Collections.Generic;

namespace StockExchange.Web.Models
{
    public class StockRates
    {
        public DateTime PublicationDate { get; set; }
        public List<Stock> Items { get; set; }
    }
}