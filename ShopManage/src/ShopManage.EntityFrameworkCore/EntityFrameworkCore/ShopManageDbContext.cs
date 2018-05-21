using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ShopManage.Authorization.Roles;
using ShopManage.Authorization.Users;
using ShopManage.MultiTenancy;
using ShopManage.Shop.Product;

namespace ShopManage.EntityFrameworkCore
{
    public class ShopManageDbContext : AbpZeroDbContext<Tenant, Role, User, ShopManageDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ShopManageDbContext(DbContextOptions<ShopManageDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("AbpProduct");
            modelBuilder.Entity<Category>().ToTable("AbpCategory");

            base.OnModelCreating(modelBuilder);
        }
    }
}
