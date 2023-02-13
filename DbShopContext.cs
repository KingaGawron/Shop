using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Shop.Models;

namespace Shop
{
    public class DbShopContext:IdentityDbContext<UserModel>
    {
        public DbShopContext(DbContextOptions<DbShopContext> options) : base(options){ }
        public DbSet<Product> Products { get; set; } 
    
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
