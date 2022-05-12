using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace DataLayer
{
    public class EFDBContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Friends> Friends{ get; set; }
        public DbSet<Library> Library { get; set; }
        public DbSet<Games> Games { get; set; }

        public EFDBContext(DbContextOptions<EFDBContext> options):base(options)
        {

        }

        
    }
    public class EFDBContextFactory :IDesignTimeDbContextFactory<EFDBContext>
    {
        public EFDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EFDBContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SteamDB;Trusted_Connection=True;MultipleActiveResultSets=true", x => x.MigrationsAssembly("DataLayer"));
            return new EFDBContext(optionsBuilder.Options);
        }
    }
    //как сделаю сущности открыть "Консоль диспетчера пакетов" и прописать Add-Migration Init1
}
