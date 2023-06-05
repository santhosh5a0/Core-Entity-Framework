using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace EFCore.Data
{
    public class EFCoreContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Address { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            ob.UseSqlServer("Data Source=SANTHOSH-REDDY\\SQLEXPRESS;Initial Catalog=EFCore;Integrated Security=true;TrustServerCertificate=True");
        }
    }
}