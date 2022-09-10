using Microsoft.EntityFrameworkCore;
using Quipu.ShoppingPlan.Repository.Model;

namespace Quipu.ShoppingPlan.Repository.EfRepository
{
    public class ShoppingPlanContext : DbContext
    {
        public DbSet<User> Users { get; set; } = default!;
        public DbSet<Article> Articles { get; set; } = default!;
        public DbSet<Category> Categories { get; set; } = default!;
        public DbSet<ShoppingTemplate> ShoppingTemplates { get; set; } = default!;
        public DbSet<ShoppingTemplateItem> ShoppingTemplateItems { get; set; } = default!;
        public DbSet<ShoppingList> ShoppingLists { get; set; } = default!;
        public DbSet<ShoppingListItem> ShoppingListItems { get; set; } = default!;

        public ShoppingPlanContext(DbContextOptions<ShoppingPlanContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TODO: Ajustes al modelo
            base.OnModelCreating(modelBuilder);
        }
    }
}
