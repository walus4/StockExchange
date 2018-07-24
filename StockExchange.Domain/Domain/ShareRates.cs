using System;

namespace StockExchange.Domain.Domain
{
    public class ShareRates
    {
        public Guid Id { get;  set; }

        public string Code { get;  set; }

        public decimal Rate { get;  set; }
        public DateTime DateTimeRates { get;  set; }

    }
}