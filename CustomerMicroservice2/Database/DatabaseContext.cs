using CustomerMicroservice2.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerMicroservice2.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=HQ-ITB-AMOSES\SQLEXPRESS; initial catalog=CustomerMicro;
                                       integrated security=True;user id=amoses;password=Spec@qe950!.;");
        }
    }
}
