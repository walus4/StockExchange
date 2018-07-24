using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockExchange.Domain.Domain
{
    public class StockActions
    {
       
        [Key]
        [ForeignKey("Company")]
        public string ActionCode { get; set; }

        public int Amount { get; set; }
        public virtual Company Company { get; set; }
    }
}