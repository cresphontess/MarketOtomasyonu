using MarketOtomasyonu.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.DAL
{
   public class MyContext:DbContext
    {
        public MyContext()
             :base("name=MarketCon")
        { }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
    }
}
