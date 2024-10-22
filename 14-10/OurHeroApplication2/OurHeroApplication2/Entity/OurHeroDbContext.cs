using Microsoft.EntityFrameworkCore;
using OurHeroApplication2.Models;

namespace OurHeroApplication2.Entity
{
   
        public class OurHeroDbContext : DbContext
        {
            public OurHeroDbContext(DbContextOptions<OurHeroDbContext> options) : base(options)
            {
            }
            // Registered DB Model in OurHeroDbContext file
            public DbSet<OurHero> OurHeros { get; set; }

            /*
             OnModelCreating mainly used to configured our EF model
             And insert master data if required
            */
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // Setting a primary key in OurHero model
                modelBuilder.Entity<OurHero>().HasKey(x => x.Id);

                // Inserting record in OurHero table
                modelBuilder.Entity<OurHero>().HasData(
                    new OurHero
                    {
                        Id = 1,
                        FirstName = "System",
                        LastName = "",
                        isActive = true,
                    }
                );
            }
        }

}
