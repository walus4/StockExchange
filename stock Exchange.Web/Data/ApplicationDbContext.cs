using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StockExchange.Domain;
using StockExchange.Domain.Domain;
using StockExchange.Web.Models;

namespace StockExchange.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Company>().HasData(
                new StockExchange.Domain.Company { Name = "Future Processing", Code = "FP", Unit = 1},
                new StockExchange.Domain.Company { Name = "FP Lab", Code = "FPL", Unit = 100},
                new StockExchange.Domain.Company { Name = "Progress Bar", Code = "PGB", Unit = 1},
                new StockExchange.Domain.Company { Name = "FP Coin", Code = "FPC", Unit = 50},
                new StockExchange.Domain.Company { Name = "FP Adventure", Code = "FPA", Unit = 50},
                new StockExchange.Domain.Company { Name = "Deadline 24", Code = "DL24", Unit = 100});

            builder.Entity<StockActions>().HasData(
                new StockActions {ActionCode = "FP", Amount = 1000},
                new StockActions { ActionCode = "FPL", Amount = 10000,  },
                new StockActions { ActionCode = "PGB", Amount = 1000000,  },
                new StockActions { ActionCode = "FPC", Amount = 50000,  },
                new StockActions { ActionCode = "FPA", Amount = 50000000,  },
                new StockActions { ActionCode = "DL24", Amount = 1000000000, }
            );

        }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<ShareRates> ShereRateses { get; set; }

        public DbSet<StockActions> StockActionses { get; set; }

        public DbSet<StockExchangeCurrency> DbStockExchangeCurrencys { get; set; }

        public DbSet<UserActions> UserActionses { get; set; }

        public DbSet<UserCurrecny> UserCurrecnies { get; set; }
    }
}
