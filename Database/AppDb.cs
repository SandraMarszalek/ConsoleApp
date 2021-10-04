using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class AppDb : DbContext
    {
        public DbSet<DictionaryDb> Dictionary { get; set; }
        public DbSet<CarDb> Car { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=AppDb2;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarDb>().HasData(
                new CarDb
                {
                    Id = 10001,
                    Model = "ModelX",
                    Price = 100000,
                    Discount = 12
                },
                new CarDb
                {
                    Id = 20002,
                    Model = "ModelY",
                    Price = 145000,
                    Discount = 8
                },
                new CarDb
                {
                    Id = 30003,
                    Model = "ModelZ",
                    Price = 243000,
                    Discount = 14
                });

            modelBuilder.Entity<DictionaryDb>().HasData(
                new DictionaryDb
                {
                    Id = 10001,
                    PlWord = "jeden",
                    EngWord = "one"
                },
                new DictionaryDb
                {
                    Id = 20002,
                    PlWord = "dwa",
                    EngWord = "two"
                },
                new DictionaryDb
                {
                    Id = 30003,
                    PlWord = "trzy",
                    EngWord = "three"
                });
        }
    }
}
