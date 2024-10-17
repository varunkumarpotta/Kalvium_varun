using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectK.Models;

namespace ProjectK.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}


		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Order> orders {  get; set; }
		public DbSet<OrderItem> orderItems { get; set; }
		public DbSet<Ingredient> ingredients { get; set; }
		public DbSet<ProductIngredient> ProductIngredients { get; set; }


		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.Entity<ProductIngredient>()
				.HasKey(HttpKeepAlivePingPolicy => new { pi.ProductId, pi.IngredientId });
		}
		
	}
}

























