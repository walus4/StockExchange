using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockExchange.Web.Models
{
    public class UserWalletViewModel
    {
        [Display(Name = "Available monay")]
        public decimal Money { get; set; }

        public List<UserStocksWallet> UserStocksWallet { get; set; }
    }
}