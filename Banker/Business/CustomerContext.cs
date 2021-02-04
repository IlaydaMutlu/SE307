using Banker.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banker.Business
{
    public class CustomerContext : DbContext
    {
        
        public CustomerContext() : base("Banker")
        {

        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Person> People { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<CustomerContext>(new DropCreateDatabaseAlways<CustomerContext>());
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Account>().ToTable("Account");
        }
    }
}
