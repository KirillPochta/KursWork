using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1
{
    public class UserContext:DbContext
    {
        public UserContext() : base("DefaultConnection")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Advert> AdvertsSet { get; set; }
        public DbSet<Products> ProductsSet { get; set; }
        public DbSet<PurchaseHistory> PurchasesSet { get; set; } 
    }
}
