using Microsoft.EntityFrameworkCore;
using Quipu.ShoppingPlan.Repository.Model;

namespace Quipu.ShoppingPlan.Repository.EfRepository
{
    public class ShoppingPlanContext : DbContext
    {
        private readonly string _connectionString;

        public DbSet<User> Users { get; set; } = default!;
        public DbSet<Article> Articles { get; set; } = default!;
        public DbSet<Category> Categories { get; set; } = default!;
        public DbSet<ShoppingTemplate> ShoppingTemplates { get; set; } = default!;
        public DbSet<ShoppingTemplateItem> ShoppingTemplateItems { get; set; } = default!;
        public DbSet<ShoppingList> ShoppingLists { get; set; } = default!;
        public DbSet<ShoppingListItem> ShoppingListItems { get; set; } = default!;

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
