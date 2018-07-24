using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace StockExchange.Domain.Domain
{
    public class ApplicationUser : IdentityUser
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNo { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public string Street { get; set; }

        public string HauseNo { get; set; }

        public string AppartamentNo { get; set; }

        public virtual UserCurrecny UserCurrecny { get; set; }
    }
}
