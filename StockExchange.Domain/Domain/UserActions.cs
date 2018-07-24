using System;

namespace StockExchange.Domain.Domain
{
    public class UserActions
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }

        public string ActionCode { get; set; }

        public int Amount { get; set; }
    }
}