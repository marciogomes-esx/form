using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Adress> Adresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasMany(c => c.ListAdress).WithOne(a => a.Customer).HasForeignKey(a => a.IdCustomer)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Customer>().HasMany(c => c.ListPhones).WithOne(a => a.Customer).HasForeignKey(a => a.IdCustomer)
                .OnDelete(DeleteBehavior.Cascade);
            
            base.OnModelCreating(modelBuilder);
        }


    }
}
