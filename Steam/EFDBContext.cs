
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Steam.Models;
using System;

namespace Steam
{
    public class EFDBContext : IdentityDbContext<User>
    {
        public DbSet<User> User { get; set; }
        public DbSet<Friends> Friends{ get; set; }
        public DbSet<Library> Library { get; set; }
        public DbSet<Games> Games { get; set; }
        public DbSet<GamesCartItem> GamesCartItem { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "96a7c7be-0830-4ea9-91ce-67844677462c",
                Name="admin"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id= "d96e88d9-2215-48f7-b437-5d70d5e5b6cd",
                UserName="admin",
                PasswordHash=new PasswordHasher<User>().HashPassword(null,"123"),
                SecurityStamp=string.Empty
            });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "96a7c7be-0830-4ea9-91ce-67844677462c",
                UserId= "d96e88d9-2215-48f7-b437-5d70d5e5b6cd"
            });
        }
        public EFDBContext(DbContextOptions<EFDBContext> options):base(options)
        {

        }

        
    }
    public class EFDBContextFactory :IDesignTimeDbContextFactory<EFDBContext>
    {
        public EFDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EFDBContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SteamDB;Trusted_Connection=True;MultipleActiveResultSets=true", x => x.MigrationsAssembly("Steam"));
            return new EFDBContext(optionsBuilder.Options);
        }
    }
    //как сделаю сущности открыть "Консоль диспетчера пакетов" и прописать Add-Migration Init1
}
