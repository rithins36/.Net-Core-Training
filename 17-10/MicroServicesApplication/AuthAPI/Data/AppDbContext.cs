using AuthAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CouponAPI.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 

        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Coupon>().HasData(new Coupon
            //{
            //    CouponId = 1,
            //    CouponCode = "100FF",
            //    DiscountAmount = 10,
            //    MinAmount = 10,
            //});

            //modelBuilder.Entity<Coupon>().HasData(new Coupon
            //{
            //    CouponId = 2,
            //    CouponCode = "200FF",
            //    DiscountAmount = 40,
            //    MinAmount = 20,
            //});
        }

    }
}
