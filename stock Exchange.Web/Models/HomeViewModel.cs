using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockExchange.Web.Models
{
    public class HomeViewModel
    {
        public StockRates StockRates { get; set; }

        public UserWalletViewModel UserWallet { get; set; }
    }
}
