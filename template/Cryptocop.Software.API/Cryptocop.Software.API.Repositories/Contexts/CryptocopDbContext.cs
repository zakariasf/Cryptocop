using Cryptocop.Software.API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cryptocop.Software.API.Repositories.Contexts
{
    public class CryptocopDbContext : DbContext
    {
        internal object users;

        public CryptocopDbContext(DbContextOptions<CryptocopDbContext> options)
        : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Addresses)
                .WithOne(a => a.User);

            modelBuilder.Entity<User>()
                .HasMany(u => u.PaymentCards)
                .WithOne(p => p.User);

            modelBuilder.Entity<User>()
                .HasOne(u => u.ShoppingCart)
                .WithOne(s => s.User);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.User);

            modelBuilder.Entity<ShoppingCart>()
                .HasMany(sc => sc.ShoppingCartItems)
                .WithOne(sci => sci.ShoppingCart);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<PaymentCard> PaymentCards { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<JwtToken> JwtTokens { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
 