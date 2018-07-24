using System;

namespace StockExchange.Domain.Domain
{
    public class StockExchangeCurrency
    {
        public Guid Id  { get; set; }

        public string CurrecyCode { get; set; }
        public decimal Amount { get; set; }
    }
}