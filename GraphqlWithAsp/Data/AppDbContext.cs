using GraphqlWithAsp.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphqlWithAsp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User {
                    Id=1,
                    Name="Imad",
                    Roll="STK122"
                },
                new User
                {
                    Id = 2,
                    Name = "Aymane",
                    Roll = "STV102"
                },
                new User
                {
                    Id = 3,
                    Name = "Mohamed",
                    Roll = "WTX162"
                },
                new User
                {
                    Id = 4,
                    Name = "Aya",
                    Roll = "SNK122"
                },
                new User
                {
                    Id = 5,
                    Name = "Yassin",
                    Roll = "STK122"
                }
                );
        }
    }
}
