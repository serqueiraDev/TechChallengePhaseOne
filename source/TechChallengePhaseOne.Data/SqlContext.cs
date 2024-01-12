using Microsoft.EntityFrameworkCore;
using TechChallengePhaseOne.Domain.Entity;

namespace TechChallengePhaseOne.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        { }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<ContaInvestimento> ContaInvestimento { get; set; }
        public DbSet<Acao> Acao { get; set; }

        //public override int SaveChanges()
        //{
        //    foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperties("DataCadastro") != null))
        //    {
        //        if (entry.State == EntityState.Added)
        //        {
        //            entry.Property("DataCadastro").CurrentValue = DateTime.Now;
        //        }
        //        if (entry.State == EntityState.Modified)
        //        {
        //            entry.Property("DataCadastro").IsModified = false;
        //        }
        //    }
        //    return base.SaveChanges();
        //}
    }
}