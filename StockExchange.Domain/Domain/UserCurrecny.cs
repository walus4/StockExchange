using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockExchange.Domain.Domain
{
    public class UserCurrecny
    {
        public Guid Id { get; set; }

        [ForeignKey("ApplicationUser")]
        public string  UserId { get; set; }

        public string CurrecyCode { get; set; }

        public decimal Amount { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}