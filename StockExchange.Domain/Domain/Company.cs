using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using StockExchange.Domain.Domain;

namespace StockExchange.Domain
{
    public class Company
    {
     
        public string Name { get;  set; }
        [Key]
        public string Code { get;  set; }

        public int Unit { get;  set; }

        public virtual StockActions StockActions { get; set; }
    }
}
