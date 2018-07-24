using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StockExchange.Web.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }

        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }

        public string City { get; set; }

        [Display(Name = "Zip code")]
        public string ZipCode { get; set; }

        public string Street { get; set; }

        [Display(Name = "Hause number")]
        public string HauseNo { get; set; }

        [Display(Name = "Appartament number")]
        public string AppartamentNo { get; set; }
    }
}
