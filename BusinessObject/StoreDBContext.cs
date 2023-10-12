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
        public StoreDBContext() : base(@"Server=(local);Database=FStore;Trusted_Connection=True;") { }
        public DbSet<MemberObject> Members { get; set; }
        public DbSet<ProductObject> Products { get; set; }
        public DbSet<OrderObject> Orders { get; set; }
        public DbSet<OrderDetailObject> OrderDetails { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MemberObject>().HasData(
                new MemberObject { Email = "admin@fstore.com", CompanyName = "FStore", City = "Hanoi", Country = "Vietnam", Password = "admin@@" }
            );
        }
    }
}
