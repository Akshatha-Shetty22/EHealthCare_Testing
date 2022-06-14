using EHealthCare_API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHealthCare_API.Data
{
    public class MedicineStoreDbContext : DbContext
    {
        public MedicineStoreDbContext()
        {

        }
        public MedicineStoreDbContext(DbContextOptions<MedicineStoreDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BSC-PG02TQPS\\SQLEXPRESS;Database=MedicineStoreDatabase;Trusted_Connection=True;MultipleActiveResultSets=true");
            //base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
