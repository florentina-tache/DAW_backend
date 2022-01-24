using DAW_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace DAW_Store.Data
{
    public class DAW_Store_context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Products { get; set; }
        public DbSet<DeliveryAddress> DeliveryAddresses { get; set; }

        //many to many
        public DbSet<OrderProductRelation> OrderProductRelations { get; set; }

        public DAW_Store_context(DbContextOptions<DAW_Store_context> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //ONE TO MANY
            builder.Entity<User>() //un user are mai multe comenzi
                .HasMany(u => u.Orders)
                .WithOne(o => o.User);

            builder.Entity<Order>() 
                .HasOne(o => o.User)
                .WithMany(u => u.Orders);


            builder.Entity<Category>() //o categorie are mai multe produse
                .HasMany(c => c.Products)
                .WithOne(p => p.Category);

            builder.Entity<Item>() 
                .HasOne(p => p.Category)
                .WithMany(c => c.Products);

            //ONE TO ONE
            builder.Entity<Order>()
                .HasOne(o => o.DeliveryAddress)
                .WithOne(d => d.Order)
                .HasForeignKey<DeliveryAddress>(d => d.OrderId);


            //MANY TO MANY
            builder.Entity<OrderProductRelation>()
                .HasKey(op => new
                {
                    op.OrderId,
                    op.ProductId
                });


            builder.Entity<OrderProductRelation>()
                .HasOne<Order>(op => op.Order)
                .WithMany(o => o.OrderProductRelations)
                .HasForeignKey(op => op.OrderId);

            builder.Entity<OrderProductRelation>()
                .HasOne<Item>(op => op.Product)
                .WithMany(p => p.OrderProductRelations)
                .HasForeignKey(op => op.ProductId);


            base.OnModelCreating(builder);
        }
    }
}