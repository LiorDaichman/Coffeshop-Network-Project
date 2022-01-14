using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CoffeShop.Models;

namespace CoffeShop.DAL
{
    public class CustomerDAL : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CustomerClass>().ToTable("CustomerUser");
        }

        public DbSet<CustomerClass> customers { get; set; }
    }
}