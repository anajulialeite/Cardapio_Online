using BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data
{
    public class MenuContext : DbContext 
    {
        public MenuContext(DbContextOptions <MenuContext> options) : base (options) { }

        public DbSet <User> Users { get; set; }

        public DbSet <Order> Orders { get; set; }

        public DbSet <Item> Items { get; set; }

        public DbSet <Category> categories { get; set; }

        public DbSet <OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne<User>(o => o.User) //um pedido percente a um usuário
                .WithMany(u => u.Orders) //um usuário pode fazer vários pedidos
                .HasForeignKey(o => o.UserID);

            modelBuilder.Entity<Item>()
                .HasOne(i => i.category)
                .WithMany(u => u.Items)
                .HasForeignKey(i => i.CategoryID);

        }
    }
}
