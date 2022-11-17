using Microsoft.EntityFrameworkCore;
using Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Data.Data
{
    public class PhoneShopDbContext : IdentityDbContext<User>
    {
        //public PhoneShopDbContext() { }
        public PhoneShopDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasMany(x => x.Orders).WithOne(x => x.User).HasForeignKey(x => x.UserId);
            modelBuilder.Entity<User>().HasOne<PaymentInfo>(x => x.PaymentInfo)
                                       .WithOne(x => x.User)
                                       .HasForeignKey<PaymentInfo>(x => x.Id);

            modelBuilder.Entity<OperationSystem>().HasData(MockData.GetOSs());
            modelBuilder.Entity<Phone>().HasData(MockData.GetPhones());
        }

        public DbSet<OperationSystem> OperationSystems { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PaymentInfo> PaymentInfos { get; set; }
    }
}
