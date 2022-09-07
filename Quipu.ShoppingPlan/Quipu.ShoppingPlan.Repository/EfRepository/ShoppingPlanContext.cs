using Microsoft.EntityFrameworkCore;
using Quipu.ShoppingPlan.Repository.Model;

namespace Quipu.ShoppingPlan.Repository.EfRepository
{
    public class ShoppingPlanContext : DbContext
    {
        private readonly string _connectionString;

        public DbSet<Article> Articles { get; set; } = default!;
        public DbSet<Category> Categories { get; set; } = default!;
        public DbSet<ShoppingTemplate> ShoppingListTemplate { get; set; } = default!;
        public DbSet<ShoppingTemplate> ShoppingList { get; set; } = default!;
        public DbSet<ShoppingTemplate> ShoppingListItem { get; set; } = default!;

        public ShoppingPlanContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TODO: Ajustes al modelo
            base.OnModelCreating(modelBuilder);
        }

    }
}
