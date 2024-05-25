using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Models;

internal class ApplicationDBContext : DbContext
{
    public virtual DbSet<SavingAccount> SavingAccount { get; set; }
    public virtual DbSet<Person> Person { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Taux;Integrated Security=True");
    }
}
