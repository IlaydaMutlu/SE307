using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Banker.Model;

namespace Banker.Business
{
    public class EmployeeContext:DbContext
    {

        public EmployeeContext() : base("Banker")
        {

        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<EmployeeContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
