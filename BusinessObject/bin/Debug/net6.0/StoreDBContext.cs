using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class StoreDBContext : DbContext
    {
        public StoreDBContext() { }
        public DbSet<MemberObject> Members { get; set; }
        public DbSet<ProductObject> Products { get; set; }
        public DbSet<OrderObject> Orders { get; set; }
        public DbSet<OrderDetailObject> OrderDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("FStore"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MemberObject>().HasData(
                new MemberObject { MemberId = 1, Email = "admin@fstore.com", CompanyName = "FStore", City = "Hanoi", Country = "Vietnam", Password = "admin@@" }
            );
        }
    }
}
