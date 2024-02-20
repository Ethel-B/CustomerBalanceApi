using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Collections.Generic;

namespace CustomerBalanceApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost, 1433; Database=CustomerBalanceApidb; Trusted_Connection=true; TrustServerCertificate=true;");
        }

        public DbSet<Customers> Customers{ get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Users> Users { get; set; }


    }
}
